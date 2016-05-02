﻿using System.Collections.Generic;
using Antlr4.Runtime;

namespace PreAdamant.Compiler.Parser
{
	public abstract class Symbol
	{
		public readonly Symbol Parent;
		public readonly string Name;
		private readonly List<Symbol> children = new List<Symbol>();
		public IReadOnlyList<Symbol> Children => children;

		protected Symbol(Symbol parent, string name)
		{
			Parent = parent;
			Name = name;
		}

		public static Symbol<T> For<T>(Symbol parent, string name, T declaration)
			where T : ParserRuleContext
		{
			return new Symbol<T>(parent, name, declaration);
		}
	}

	public class Symbol<T> : Symbol
		where T : ParserRuleContext
	{
		private readonly List<T> declarations;
		public IReadOnlyList<T> Declarations => declarations;

		public Symbol(Symbol parent, string name, T declaration)
			: base(parent, name)
		{
			declarations = new List<T>() { declaration };
		}
	}
}