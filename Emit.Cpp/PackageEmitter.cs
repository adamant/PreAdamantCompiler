﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PreAdamant.Compiler.Common;
using PreAdamant.Compiler.Semantics;
using PreAdamant.Compiler.Syntax;
using static PreAdamant.Compiler.Syntax.PreAdamantParser;
using Requires = PreAdamant.Compiler.Common.Requires;

namespace PreAdamant.Compiler.Emit.Cpp
{
	public class PackageEmitter
	{
		private readonly PackageSemantics package;

		public PackageEmitter(PackageSemantics package)
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
			//foreach(var dependency in package.Dependencies)
			//	source.WriteIndentedLine($"#include \"{dependency.Package.Name}.cpp\"");

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
			//EmitDefinition(source, package.Symbol.Children);
			source.EndBlock();

			EmitEntryPoint(source);

			return source.ToString();
		}

		#region EmitDeclaration
		private static void EmitDeclaration(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		{
			foreach(var symbol in symbols)
			{
				if(symbol.Declarations.Count == 1)
					symbol.Declarations[0].Match()
						.With<FunctionDeclarationSyntax>(func =>
						{
							source.WriteIndentedLine(Signature(func) + ";");
						})
						.Exhaustive();
				else
					throw new NotImplementedException("Multiple or no declarations of symbol");
			}


			//		.With<Symbol<NamespaceDeclarationContext>>(nsSymbol =>
			//		{
			//			source.WriteIndentedLine($"namespace {nsSymbol.Name}");
			//			source.BeginBlock();
			//			EmitDeclaration(source, nsSymbol.Children);
			//			source.EndBlock();
			//		})

			//		.With<Symbol<ClassDeclarationContext>>(classSymbol =>
			//		{
			//			var @class = classSymbol.Declarations.Single();
			//			source.WriteIndentedLine(Signature(@class));
			//			source.BeginBlock();
			//			EmitDeclaration(source, classSymbol.Children);
			//			source.EndBlockWithSemicolon();
			//		})
			//		.With<Symbol<StructDeclarationContext>>(structSymbol =>
			//		{
			//			var @struct = structSymbol.Declarations.Single();
			//			source.WriteIndentedLine(Signature(@struct));
			//			source.BeginBlock();
			//			EmitDeclaration(source, structSymbol.Children);
			//			source.EndBlockWithSemicolon();
			//		})
			//		.With<Symbol<MethodContext>>(methodSymbol =>
			//		{
			//			var method = methodSymbol.Declarations.Single();
			//			source.WriteIndentedLine($"{Signature(method.accessModifier())}: {Signature(method, false)};");
			//		})
			//		.With<Symbol<ConstructorContext>>(constructorSymbol =>
			//		{
			//			var constructor = constructorSymbol.Declarations.Single();
			//			source.WriteIndentedLine($"{Signature(constructor.accessModifier())}: {Signature(constructor, false)};");
			//		})
			//		.With<Symbol<FieldContext>>(fieldSymbol =>
			//		{
			//			var field = fieldSymbol.Declarations.Single();
			//			source.WriteIndentedLine($"{Signature(field.accessModifier())}: {TypeName(field.valueType(), field.IsMutable)} {field.identifier().Name};");
			//		})
			//		.Exhaustive();
		}
		#endregion

		#region EmitDefinition
		//	private static void EmitDefinition(SourceFileBuilder source, IEnumerable<Symbol> symbols)
		//	{
		//		foreach(var symbol in symbols)
		//			symbol.Match()
		//				.With<Symbol<NamespaceDeclarationContext>>(nsSymbol =>
		//				{
		//					source.WriteIndentedLine($"namespace {nsSymbol.Name}");
		//					source.BeginBlock();
		//					EmitDefinition(source, nsSymbol.Children);
		//					source.EndBlock();
		//				})
		//				.With<Symbol<FunctionDeclarationContext>>(funcSymbol =>
		//				{
		//					var func = funcSymbol.Declarations.Single();

		//					source.WriteIndentedLine(Signature(func));
		//					source.BeginBlock();
		//					EmitDefinition(source, func.methodBody());
		//					source.EndBlock();
		//				})
		//				.With<Symbol<ClassDeclarationContext>>(classSymbol =>
		//				{
		//					EmitDefinition(source, classSymbol.Children);
		//				})
		//				.With<Symbol<MethodContext>>(methodSymbol =>
		//				{
		//					var method = methodSymbol.Declarations.Single();

		//					source.WriteIndentedLine(Signature(method, true));
		//					source.BeginBlock();
		//					EmitDefinition(source, method.methodBody());
		//					source.EndBlock();
		//				})
		//				.With<Symbol<ConstructorContext>>(constructorSymbol =>
		//				{
		//					var constructor = constructorSymbol.Declarations.Single();

		//					source.WriteIndentedLine(Signature(constructor, true));
		//					source.BeginBlock();
		//					EmitDefinition(source, constructor.methodBody());
		//					source.EndBlock();
		//				})
		//				.Ignore<Symbol<FieldContext>>() // TODO still need to put field initlizers in
		//				.Exhaustive();
		//	}

		//	private static void EmitDefinition(SourceFileBuilder source, MethodBodyContext methodBody)
		//	{
		//		foreach(var statement in methodBody.Statements)
		//			EmitDefinition(source, statement);
		//	}

		//	private static void EmitDefinition(SourceFileBuilder source, StatementContext statement)
		//	{
		//		statement.Match()
		//			.With<ReturnStatementContext>(@return =>
		//			{
		//				var code = @return.expression() != null ? $"return {CodeFor(@return.expression())};" : "return;";
		//				source.WriteIndentedLine(code);
		//			})
		//			.With<ExpressionStatementContext>(expStatement =>
		//			{
		//				source.WriteIndentedLine(CodeFor(expStatement.expression()) + ";");
		//			})
		//			.With<VariableDeclarationStatementContext>(varDeclarationStatement =>
		//			{
		//				source.WriteIndentedLine($"{CodeFor(varDeclarationStatement.localVariableDeclaration())};");
		//			})
		//			.Exhaustive();
		//	}
		#endregion

		#region CodeFor
		//	private static string CodeFor(ExpressionContext expression)
		//	{
		//		return expression.Match().Returning<string>()
		//			.With<IntLiteralExpressionContext>(literal =>
		//			{
		//				// TODO use the correctly calculated type for this
		//				return $"((int32_t){literal.Value})";
		//			})
		//			.With<CastExpressionContext>(cast =>
		//			{
		//				var type = cast.kind.Text;
		//				switch(type)
		//				{
		//					case "as!":
		//						return $"(({TypeName(cast.typeName())}){CodeFor(cast.expression())})";
		//					default:
		//						throw new NotSupportedException($"Cast type '{type}' not supported");
		//				}
		//			})
		//			.With<MemberExpressionContext>(memberAccess =>
		//			{
		//				var exp = CodeFor(memberAccess.expression());
		//				var member = memberAccess.identifier().GetText();
		//				var nameExp = memberAccess.expression() as NameExpressionContext;
		//				// Handle static methods and the special case of IntrinsicMethods
		//				if(nameExp != null && (
		//					(nameExp.ReferencedSymbol == null && nameExp.GetText() == "IntrinsicMethods")
		//					|| nameExp.ReferencedSymbol is Symbol<ClassDeclarationContext>))
		//					return $"{exp}::{member}";
		//				return $"({exp})->{member}";
		//			})
		//			.With<StringLiteralExpressionContext>(literal =>
		//			{
		//				var encodedValue = Encoding.UTF8.GetBytes(literal.Value);
		//				var bytes = string.Join(", ", encodedValue.Select(b => "0x" + b.ToString("X")));
		//				var unsafeArray = $"new uint8_t[{encodedValue.Length}]{{{bytes}}}";
		//				return $"new ::__Adamant::Runtime::string((size_t){encodedValue.Length}, {unsafeArray})";
		//			})
		//			.With<CallExpressionContext>(call =>
		//			{
		//				var args = call.argumentList()._expressions.Select(CodeFor);
		//				return $"{CodeFor(call.expression())}({string.Join(", ", args)})";
		//			})
		//			.With<NameExpressionContext>(name =>
		//			{
		//				if(name.ReferencedSymbol == null && name.GetText() == "IntrinsicMethods")
		//					return "::__Adamant::Runtime::IntrinsicMethods";
		//				return QualifiedName(name.ReferencedSymbol);
		//			})
		//			.With<NewExpressionContext>(@newExpression =>
		//			{
		//				var typeName = TypeName(@newExpression.name());
		//				var args = @newExpression.constructorArguments._expressions.Select(CodeFor);
		//				return $"new {typeName}({string.Join(", ", args)})";
		//			})
		//			.With<AssignmentExpressionContext>(assignmentExpression =>
		//			{
		//				var left = CodeFor(assignmentExpression.lvalue);
		//				var right = CodeFor(assignmentExpression.rvalue);
		//				return $"{left} {assignmentExpression.op.Text} {right}";
		//			})
		//			// Currently, awaits are handled as synchronous calls
		//			.With<AwaitExpressionContext>(awaitExpression => CodeFor(awaitExpression.expression()))
		//			.Any(() =>
		//			{
		//				throw new Exception($"Match not exhaustive for expression '{expression.GetText()}' of type '{expression.GetType().Name}'");
		//			});
		//	}

		//	private static string CodeFor(LocalVariableDeclarationContext declaration)
		//	{
		//		var isMutable = declaration.IsMutable; // i.e. var vs let
		//		var type = TypeName(declaration.valueType(), isMutable);
		//		// TODO deal with destructuring assignment
		//		var expression = declaration.expression();
		//		var result = $"{type} {declaration.Name}";
		//		if(expression != null)
		//			result += " = " + CodeFor(expression);
		//		return result;
		//	}
		#endregion

		#region Names
		//	private static string QualifiedName(Symbol symbol)
		//	{
		//		Requires.NotNull(symbol, nameof(symbol));

		//		return symbol.Match().Returning<string>()
		//			// Start with :: becuase we are fully qualified and don't want to ever accidently pick up the wrong thing
		//			.With<Symbol<PackageContext>>(package => "::" + PackageName(symbol))
		//			.With<Symbol<NamedParameterContext>>(param => symbol.Name)
		//			.With<Symbol<LocalVariableDeclarationContext>>(var => var.Name)
		//			.Any(() => QualifiedName(symbol.Parent) + "::" + symbol.Name);
		//	}

		private static string PackageName(Symbol symbol)
		{
			return symbol.Name.Replace(".", "__");
		}
		#endregion

		#region Signatures
		private static string Signature(FunctionDeclarationSyntax func)
		{
			var @params = func.ParameterList.Parameters.Cast<NamedParameterSyntax>().Select(Signature);
			// Use C++11 return types syntax becuase of problems with fully qualified method names
			return $"auto {func.Identifier.Value}({string.Join(", ", @params)}) -> {TypeName(func.ReturnType, true)}";
		}

		//	private static string Signature(MethodContext method, bool qualified)
		//	{
		//		var @params = method.Parameters.OfType<NamedParameterContext>().Select(Signature);
		//		var selfParam = method.Parameters.OfType<SelfParameterContext>().SingleOrDefault(); // TODO deal with static methods
		//		if(selfParam == null)
		//			throw new NotImplementedException("Associated functions (aka static methods) not implemented");
		//		var constMethod = selfParam.IsMutable ? "" : " const";
		//		var @class = method.Symbol.Parent;
		//		var name = qualified ? $"{QualifiedName(@class)}::{method.Name}" : method.Name;
		//		// Use C++11 return types syntax becuase of problems with fully qualified method names
		//		return $"auto {name}({string.Join(", ", @params)}){constMethod} -> {TypeName(method.returnType(), true)}";
		//	}

		//	private static string Signature(ConstructorContext constructor, bool qualified)
		//	{
		//		var @params = constructor.Parameters.OfType<NamedParameterContext>().Select(Signature);
		//		var @class = constructor.Symbol.Parent;
		//		var name = qualified ? $"{QualifiedName(@class)}::{@class.Name}" : @class.Name;
		//		return $"{name}({string.Join(", ", @params)})";
		//	}

		private static string Signature(NamedParameterSyntax param)
		{
			return $"{TypeName(param.ValueType, param.IsVar)} {param.Identifier.Value}";
		}

		//	private static string Signature(ClassDeclarationContext @class)
		//	{
		//		string template = "";
		//		if(@class.typeParameters() != null)
		//		{
		//			var typeParams = @class.typeParameters().typeParameter().Select(tp => "typename " + tp.identifier().Name);
		//			template = $"template<{string.Join(", ", typeParams)}> ";
		//		}
		//		return template + $"class {@class.Name}";
		//	}

		//	private static string Signature(StructDeclarationContext @struct)
		//	{
		//		string template = "";
		//		if(@struct.typeParameters() != null)
		//		{
		//			var typeParams = @struct.typeParameters().typeParameter().Select(tp => "typename " + tp.identifier().Name);
		//			template = $"template<{string.Join(", ", typeParams)}> ";
		//		}
		//		return template + $"struct {@struct.Name}";
		//	}

		//	private static string Signature(AccessModifierContext accessModifier)
		//	{
		//		switch(accessModifier.token.Type)
		//		{
		//			case Public:
		//			case Internal:
		//				return "public";
		//			case Private:
		//				return "private";
		//			case Protected:
		//				return "protected";
		//			default:
		//				throw new NotSupportedException($"Access modifier {accessModifier.token.Text} ({accessModifier.token.Type}) not supported");
		//		}
		//	}
		#endregion

		#region TypeNames
		private static string TypeName(ReturnTypeSyntax returnType, bool isMutable)
		{
			// This is the case of a non-terminating function i.e. `-> !`
			if(returnType.Diverges)
				return "void /*!*/";

			return TypeName(returnType.Type, isMutable);
		}

		private static string TypeName(TypeSyntax type, bool isMutable)
		{
			if(type.IsVoid)
				return "void";

			return TypeName(type.ValueType, isMutable);
		}

		private static string TypeName(ValueTypeSyntax type, bool isMutable)
		{
			return type.Match().Returning<string>()
				.With<LifetimeTypeSyntax>(t => TypeName(t, isMutable))
				.With<RefTypeSyntax>(t => TypeName(t, isMutable))
				.Exhaustive();
		}

		private static string TypeName(LifetimeTypeSyntax type, bool isMutable)
		{
			var typeName = TypeName(type.TypeName);
			throw new NotImplementedException();
			//var referencedSymbol = type.TypeName.ReferencedSymbol;
			//if(referencedSymbol == null)
			//	throw new Exception($"TypeName not resolved to a symbol `{type.TypeName.GetText()}`");
			//var isReferenceType = referencedSymbol is Symbol<ClassDeclarationSyntax>;
			//if(!isReferenceType && !(referencedSymbol is Symbol<StructDeclarationSyntax>))
			//	throw new Exception($"TypeName `{type.TypeName.GetText()}` references symbol that is neither class nor struct");

			//if(isReferenceType)
			//	// pointer, const depends on if it is mutable i.e. `mut`
			//	typeName += type.IsMutable ? "*" : " const *";
			//else if(type.IsMutable)
			//	throw new Exception("`mut` is not valid on struct types");

			//// the binding is mutable i.e. `let` vs `var`
			//if(!isMutable)
			//	typeName += " const";

			//return typeName;
		}

		private static string TypeName(RefTypeSyntax type, bool isMutable)
		{
			throw new NotImplementedException();
		}

		private static string TypeName(TypeNameSyntax type)
		{
			return type.Match().Returning<string>()
				.With<NamedTypeSyntax>(namedType => TypeName(namedType.Name))
				.With<PointerTypeSyntax>(pointerType => "*" + (pointerType.IsMutable ? "" : "const ") + TypeName(pointerType.TypeName))
				.Exhaustive();
		}

		private static string TypeName(NameSyntax name)
		{
			return name.Match().Returning<string>()
				.With<UnqualifiedNameSyntax>(unqualifiedName => TypeName(unqualifiedName.SimpleName))
				.With<QualifiedNameSyntax>(qualifiedName => { throw new NotImplementedException(); })
				.Exhaustive();
		}

		private static string TypeName(SimpleNameSyntax simpleName)
		{
			//throw new NotImplementedException();
			return simpleName.Match().Returning<string>()
				.With<IdentifierNameSyntax>(identifierName =>
				{
					var symbol = identifierName.ReferencedSymbol;
					if(identifierName.ReferencedSymbol == null)
						throw new Exception($"Identifier '{identifierName.GetText()}' not resolved to a symbol");

					if(!symbol.IsPredefined)
						return QualifiedName(symbol);

					var code = symbol.Name;
					switch(symbol.Name)
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
						case "size":
							code += "_t";
							break;
						case "offset":
							code = "ptrdiff_t";
							break;
						default:
							throw new NotImplementedException($"Predefined type '{symbol.Name}' not implemented");
					}
					return code;
				})
				.Exhaustive();
		}
		#endregion

		private void EmitEntryPoint(SourceFileBuilder source)
		{
			//		var entryPoint = package.EntryPoints().SingleOrDefault();
			//		if(entryPoint == null) return;

			source.WriteLine();
			source.WriteIndentedLine("// Entry Point");
			source.WriteIndentedLine("int main(int argc, char *argv[])");
			source.BeginBlock();
			//		var index = 0;
			//		foreach(var parameter in entryPoint.Declarations.Single().Parameters.Cast<NamedParameterContext>())
			//		{
			//			source.WriteIndentedLine($"auto arg_{index++} = new {TypeName(parameter.valueType().TypeName)}();");
			//		}
			//		var arguments = string.Join(", ", Enumerable.Range(0, index).Select(i => $"arg_{i}"));

			//		var entryPointName = QualifiedName(entryPoint);
			//		var entryFunction = entryPoint.Declarations.Single();
			//		var returnType = TypeName(entryFunction.returnType(), true);
			//		switch(returnType)
			//		{
			//			case "void":
			//				source.WriteIndentedLine($"{entryPointName}({arguments});");
			//				source.WriteIndentedLine("return 0;");
			//				break;
			//			case "int32_t":
			//				source.WriteIndentedLine($"return {entryPointName}({arguments});");
			//				break;
			//			default:
			//				throw new NotSupportedException($"Entry point return type of `{returnType}` not supported");
			//		}
			source.EndBlock();
		}
	}
}
