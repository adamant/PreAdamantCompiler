﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Parser;
using static PreAdamant.Compiler.Parser.PreAdamantParser;
using Requires = PreAdamant.Compiler.Common.Requires;

namespace PreAdamant.Compiler.Emit.Cpp
{
	public class PackageEmitter
	{
		private readonly PackageContext package;

		public PackageEmitter(PackageContext package)
		{
			this.package = package;
		}

		public string Emit()
		{
			var source = new SourceFileBuilder();
			source.WriteIndentedLine("#pragma once");
			source.WriteLine();

			source.WriteIndentedLine("// Dependencies");
			source.WriteIndentedLine("#include <cstdint>");
			source.WriteIndentedLine($"#include \"{CppRuntime.FileName}\"");
			foreach(var dependency in package.Dependencies)
				source.WriteIndentedLine($"#include \"{dependency.Package.Name}.cpp\"");

			source.WriteLine();
			source.WriteIndentedLine("// Package Declaration");
			source.WriteIndentedLine($"namespace {PackageName(package.Symbol)}");
			source.BeginBlock();
			EmitDeclaration(source, package.Symbol.Children);
			source.EndBlock();

			source.WriteLine();
			source.WriteIndentedLine("// Package Definition");
			source.WriteIndentedLine($"namespace {PackageName(package.Symbol)}");
			source.BeginBlock();
			EmitDefinition(source, package.Symbol.Children);
			source.EndBlock();

			EmitEntryPoint(source);

			return source.ToString();
		}

		#region EmitDeclaration
		private static void EmitDeclaration(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
				symbol.Match()
					.With<Symbol<NamespaceDeclarationContext>>(nsSymbol =>
					{
						source.WriteIndentedLine($"namespace {nsSymbol.Name}");
						source.BeginBlock();
						EmitDeclaration(source, nsSymbol.Children);
						source.EndBlock();
					})
					.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
					{
						var func = funcSymbol.Declarations.Single();
						source.WriteIndentedLine(Signature(func) + ";");
					})
					.With<Symbol<ClassDeclarationContext>>(classSymbol =>
					{
						var @class = classSymbol.Declarations.Single();
						source.WriteIndentedLine(Signature(@class));
						source.BeginBlock();
						EmitDeclaration(source, classSymbol.Children);
						source.EndBlockWithSemicolon();
					})
					.With<Symbol<MethodContext>>(methodSymbol =>
					{
						var method = methodSymbol.Declarations.Single();
						source.WriteIndentedLine($"{Signature(method.accessModifier())}: {Signature(method)};");
					})
					.Exhaustive();
		}
		#endregion

		#region EmitDefinition
		private static void EmitDefinition(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
				symbol.Match()
					.With<Symbol<NamespaceDeclarationContext>>(nsSymbol =>
					{
						source.WriteIndentedLine($"namespace {nsSymbol.Name}");
						source.BeginBlock();
						EmitDefinition(source, nsSymbol.Children);
						source.EndBlock();
					})
					.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
					{
						var func = funcSymbol.Declarations.Single();

						source.WriteIndentedLine(Signature(func));
						source.BeginBlock();
						EmitDefinition(source, func.methodBody());
						source.EndBlock();
					})
					.With<Symbol<ClassDeclarationContext>>(classSymbol =>
					{
						EmitDefinition(source, classSymbol.Children);
					})
					.With<Symbol<MethodContext>>(methodSymbol =>
					{
						var method = methodSymbol.Declarations.Single();

						source.WriteIndentedLine(Signature(method));
						source.BeginBlock();
						EmitDefinition(source, method.methodBody());
						source.EndBlock();
					})
					.Exhaustive();
		}

		private static void EmitDefinition(SourceFileBuilder source, MethodBodyContext methodBody)
		{
			foreach(var statement in methodBody.Statements)
				EmitDefinition(source, statement);
		}

		private static void EmitDefinition(SourceFileBuilder source, StatementContext statement)
		{
			statement.Match()
				.With<ReturnStatementContext>(@return =>
				{
					var code = @return.expression() != null ? $"return {CodeFor(@return.expression())};" : "return;";
					source.WriteIndentedLine(code);
				})
				.With<ExpressionStatementContext>(expStatement =>
				{
					source.WriteIndentedLine(CodeFor(expStatement.expression()) + ";");
				})
				.With<VariableDeclarationStatementContext>(varDeclarationStatement =>
				{
					source.WriteIndentedLine($"{CodeFor(varDeclarationStatement.localVariableDeclaration())};");
				})
				.Exhaustive();
		}
		#endregion

		#region CodeFor
		private static string CodeFor(ExpressionContext expression)
		{
			return expression.Match().Returning<string>()
				.With<IntLiteralExpressionContext>(literal =>
				{
					// TODO use the correctly calculated type for this
					return $"new int32_t({literal.Value})";
				})
				.With<CastExpressionContext>(cast =>
				{
					var type = cast.kind.Text;
					switch(type)
					{
						case "as!":
							return $"new {TypeName(cast.valueType())}(*({CodeFor(cast.expression())}))";
						default:
							throw new NotSupportedException($"Cast type '{type}' not supported");
					}
				})
				.With<MemberExpressionContext>(memberAccess => $"({CodeFor(memberAccess.expression())})->{memberAccess.identifier().GetText()}")
				.With<StringLiteralExpressionContext>(literal =>
				{
					var encodedValue = Encoding.UTF8.GetBytes(literal.Value);
					var bytes = string.Join(", ", encodedValue.Select(b => "0x" + b.ToString("X")));
					var unsafeArray = $"new uint8_t[{encodedValue.Length}]{{{bytes}}}";
					return $"new ::__Adamant::Runtime::string(new size_t({encodedValue.Length}), {unsafeArray})";
				})
				.With<CallExpressionContext>(call =>
				{
					var args = call.argumentList()._expressions.Select(CodeFor);
					return $"{CodeFor(call.expression())}({string.Join(", ", args)})";
				})
				.With<NameExpressionContext>(name => QualifiedName(name.ReferencedSymbol))
				.With<NewExpressionContext>(@newExpression =>
				{
					var typeName = TypeName(@newExpression.name());
					var args = @newExpression.argumentList()._expressions.Select(CodeFor);
					return $"new {typeName}({string.Join(", ", args)})";
				})
				.Exhaustive();
		}

		private static string CodeFor(LocalVariableDeclarationContext declaration)
		{
			var isMutable = declaration.IsMutable; // i.e. var vs let
			var type = TypeName(declaration.referenceType(), isMutable);
			// TODO deal with destructuring assignment
			var expression = declaration.expression();
			var result = $"{type} {declaration.Name}";
			if(expression != null)
				result += " = " + CodeFor(expression);
			return result;
		}
		#endregion

		#region Names
		private static string QualifiedName(Symbol symbol)
		{
			Requires.NotNull(symbol, nameof(symbol));

			return symbol.Match().Returning<string>()
				// Start with :: becuase we are fully qualified and don't want to ever accidently pick up the wrong thing
				.With<Symbol<PackageContext>>(package => "::" + PackageName(symbol))
				.With<Symbol<NamedParameterContext>>(param => symbol.Name)
				.With<Symbol<LocalVariableDeclarationContext>>(var => var.Name)
				.Any(() => QualifiedName(symbol.Parent) + "::" + symbol.Name);
		}

		private static string PackageName(Symbol symbol)
		{
			return symbol.Name.Replace(".", "__");
		}
		#endregion

		#region Signatures
		private static string Signature(FunctionDeclarationContext func)
		{
			var @params = func.Parameters.Cast<NamedParameterContext>().Select(Signature);
			return $"{TypeName(func.returnType, true)} {func.Name}({string.Join(", ", @params)})";
		}

		private static string Signature(MethodContext method)
		{
			var @params = method.Parameters.OfType<NamedParameterContext>().Select(Signature);
			var selfParam = method.Parameters.OfType<SelfParameterContext>().SingleOrDefault(); // TODO deal with static methods
			var constMethod = selfParam.IsMutable ? "" : " const";
			var @class = method.Symbol.Parent;
			return $"{TypeName(method.returnType, true)} {QualifiedName(@class)}::{method.Name}({string.Join(", ", @params)}){constMethod}";
		}

		private static string Signature(NamedParameterContext param)
		{
			var isVar = param.isVar != null;
			return $"{TypeName(param.referenceType(), isVar)} {param.identifier().GetText()}";
		}

		private static string Signature(ClassDeclarationContext @class)
		{
			return $"class {@class.Name}";
		}

		private static string Signature(AccessModifierContext accessModifier)
		{
			switch(accessModifier.token.Type)
			{
				case Public:
				case Internal:
					return "public";
				case Private:
					return "private";
				case Protected:
					return "protected";
				default:
					throw new NotSupportedException($"Access modifier {accessModifier.token.Text} ({accessModifier.token.Type}) not supported");
			}
		}
		#endregion

		#region TypeNames
		private static string TypeName(ReferenceTypeContext type, bool isMutable)
		{
			var typeName = TypeName(type.ValueType);
			if(typeName == "void") return typeName;
			// the value is mutable i.e. `mut`
			typeName += (type.IsMutable ? "*" : " const *");
			// the reference is mutable i.e. `let` vs `var`
			if(!isMutable) typeName += " const";
			return typeName;
		}

		private static string TypeName(ValueTypeContext type)
		{
			return type.Match().Returning<string>()
				.With<NamedTypeContext>(namedType => TypeName(namedType.name()))
				.Exhaustive();
		}

		private static string TypeName(NameContext name)
		{
			return name.Match().Returning<string>()
				.With<UnqualifiedNameContext>(unqualifiedName => TypeName(unqualifiedName.simpleName()))
				.With<QualifiedNameContext>(qualifiedName => { throw new NotImplementedException(); })
				.Exhaustive();
		}

		private static string TypeName(SimpleNameContext simpleName)
		{
			return simpleName.Match().Returning<string>()
				.With<IdentifierNameContext>(identifierName =>
				{
					var code = identifierName.GetText();
					switch(code)
					{
						case "void":
							break;
						case "int":
						case "uint":
							code += "32_t";
							break;
						case "string":
							code = "::__Adamant::Runtime::string";
							break;
						default:
							if(identifierName.ReferencedSymbol == null)
								throw new Exception($"Identifier '{identifierName.GetText()}' not resolved to a symbol");
							code = QualifiedName(identifierName.ReferencedSymbol);
							break;
					}
					return code;
				})
				.Exhaustive();
		}
		#endregion

		private void EmitEntryPoint(SourceFileBuilder source)
		{
			var entryPoint = package.EntryPoints().SingleOrDefault();
			if(entryPoint == null) return;

			source.WriteLine();
			source.WriteIndentedLine("// Entry Point");
			source.WriteIndentedLine("int main(int argc, char *argv[])");
			source.BeginBlock();
			var entryPointName = QualifiedName(entryPoint);
			var entryFunction = entryPoint.Declarations.Single();
			var returnType = TypeName(entryFunction.returnType, true);
			switch(returnType)
			{
				case "void":
					source.WriteIndentedLine($"{entryPointName}();");
					source.WriteIndentedLine("return 0;");
					break;
				case "int32_t*":
				case "int32_t const *":
					source.WriteIndentedLine($"auto exitCodePtr = {entryPointName}();");
					source.WriteIndentedLine("auto exitCode = *exitCodePtr;");
					source.WriteIndentedLine("delete exitCodePtr;");
					source.WriteIndentedLine("return exitCode;");
					break;
				default:
					throw new NotSupportedException($"Entry point return type of `{returnType}` not supported");
			}
			source.EndBlock();
		}
	}
}
