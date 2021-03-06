﻿using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Tree;
using static PreAdamant.Compiler.Tools.Parse.SpecParser;

namespace PreAdamant.Compiler.Tools.Parse
{
	public class Rule
	{
		public string Name { get; }
		public string Base { get; }
		public PatternContext Pattern { get; }
		public IReadOnlyCollection<string> Attributes { get; }
		public IReadOnlyList<ChildRule> Children { get; }

		public Rule(string name, string @base, PatternContext pattern, IEnumerable<string> attributes)
		{
			Name = name;
			Base = @base;
			Pattern = pattern;
			Attributes = new HashSet<string>(attributes);
			Children = BuildChildren(pattern, null, false).ToList();
		}

		private static IEnumerable<ChildRule> BuildChildren(IParseTree context, string label, bool repeated)
		{
			var rulePattern = context as RulePatternContext;
			if(rulePattern != null)
			{
				if(rulePattern.ruleName.Text == "EOF") return Enumerable.Empty<ChildRule>();
				return new[] { new ChildRule(rulePattern.ruleName.Text, label, repeated) };
			}
			var literalPattern = context as LiteralPatternContext;
			if(literalPattern != null && label != null)
			{
				return new[] { new ChildRule(null, label, repeated) };
			}

			var optionalPattern = context as OptionalPatternContext;
			if(optionalPattern != null)
				return BuildChildren(optionalPattern.pattern(), label, repeated);
			var groupingPattern = context as GroupingPatternContext;
			if(groupingPattern != null)
				return BuildChildren(groupingPattern.pattern(), label, repeated);
			var labelPattern = context as LabelPatternContext;
			if(labelPattern != null)
				return BuildChildren(labelPattern.pattern(), labelPattern.label.Text, repeated);
			var concatPattern = context as ConcatPatternContext;
			if(concatPattern != null)
				return BuildChildren(concatPattern.pattern(0), label, repeated).Concat(BuildChildren(concatPattern.pattern(1), label, repeated));
			var alternationPattern = context as AlternationPatternContext;
			if(alternationPattern != null)
				return Distinct(BuildChildren(alternationPattern.pattern(0), label, repeated), BuildChildren(alternationPattern.pattern(1), label, repeated));

			// Repetition Patterns
			var zeroOrMorePattern = context as ZeroOrMorePatternContext;
			if(zeroOrMorePattern != null)
				return BuildChildren(zeroOrMorePattern.pattern(), label, true);
			var oneOrMorePattern = context as OneOrMorePatternContext;
			if(oneOrMorePattern != null)
				return BuildChildren(oneOrMorePattern.pattern(), label, true);
			var repititionWithPattern = context as RepeatWithSeparatorPatternContext;
			if(repititionWithPattern != null)
				return BuildChildren(repititionWithPattern.pattern(), label, true);

			// Skipped things
			if(context is LiteralPatternContext || context is ITerminalNode)
				return Enumerable.Empty<ChildRule>();

			throw new NotSupportedException($"Pattern {context.GetType().Name} not supported.");
		}

		private static IEnumerable<ChildRule> Distinct(IEnumerable<ChildRule> first, IEnumerable<ChildRule> second)
		{
			return first.Concat(second)
				.GroupBy(r => r.Label)
				.Select(g => g.First());
		}
	}
}
