//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SpecParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreAdamant.Compiler.Tools.Lex {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SpecParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface ISpecParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpecParser.spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpec([NotNull] SpecParser.SpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpecParser.spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpec([NotNull] SpecParser.SpecContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NameDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameDirective([NotNull] SpecParser.NameDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NameDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameDirective([NotNull] SpecParser.NameDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NamespaceDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceDirective([NotNull] SpecParser.NamespaceDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NamespaceDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceDirective([NotNull] SpecParser.NamespaceDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ImportDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDirective([NotNull] SpecParser.ImportDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ImportDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDirective([NotNull] SpecParser.ImportDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>StartModeDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStartModeDirective([NotNull] SpecParser.StartModeDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StartModeDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStartModeDirective([NotNull] SpecParser.StartModeDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ChannelsDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChannelsDirective([NotNull] SpecParser.ChannelsDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ChannelsDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChannelsDirective([NotNull] SpecParser.ChannelsDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IncludeDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncludeDirective([NotNull] SpecParser.IncludeDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IncludeDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncludeDirective([NotNull] SpecParser.IncludeDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ModesDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModesDirective([NotNull] SpecParser.ModesDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ModesDirective</c>
	/// labeled alternative in <see cref="SpecParser.directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModesDirective([NotNull] SpecParser.ModesDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpecParser.parseRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParseRule([NotNull] SpecParser.ParseRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpecParser.parseRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParseRule([NotNull] SpecParser.ParseRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LiteralPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralPattern([NotNull] SpecParser.LiteralPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LiteralPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralPattern([NotNull] SpecParser.LiteralPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DifferencePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDifferencePattern([NotNull] SpecParser.DifferencePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DifferencePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDifferencePattern([NotNull] SpecParser.DifferencePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OptionalPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionalPattern([NotNull] SpecParser.OptionalPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OptionalPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionalPattern([NotNull] SpecParser.OptionalPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ZeroOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterZeroOrMorePattern([NotNull] SpecParser.ZeroOrMorePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ZeroOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitZeroOrMorePattern([NotNull] SpecParser.ZeroOrMorePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UpToPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpToPattern([NotNull] SpecParser.UpToPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UpToPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpToPattern([NotNull] SpecParser.UpToPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IntersectionPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntersectionPattern([NotNull] SpecParser.IntersectionPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IntersectionPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntersectionPattern([NotNull] SpecParser.IntersectionPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AnyPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnyPattern([NotNull] SpecParser.AnyPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AnyPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnyPattern([NotNull] SpecParser.AnyPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NegatePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNegatePattern([NotNull] SpecParser.NegatePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NegatePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNegatePattern([NotNull] SpecParser.NegatePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OneOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneOrMorePattern([NotNull] SpecParser.OneOrMorePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OneOrMorePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneOrMorePattern([NotNull] SpecParser.OneOrMorePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RepeatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeatPattern([NotNull] SpecParser.RepeatPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RepeatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeatPattern([NotNull] SpecParser.RepeatPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRulePattern([NotNull] SpecParser.RulePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRulePattern([NotNull] SpecParser.RulePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AlternationPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlternationPattern([NotNull] SpecParser.AlternationPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AlternationPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlternationPattern([NotNull] SpecParser.AlternationPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupingPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupingPattern([NotNull] SpecParser.GroupingPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupingPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupingPattern([NotNull] SpecParser.GroupingPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ImportedRulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportedRulePattern([NotNull] SpecParser.ImportedRulePatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ImportedRulePattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportedRulePattern([NotNull] SpecParser.ImportedRulePatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CharClassPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharClassPattern([NotNull] SpecParser.CharClassPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CharClassPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharClassPattern([NotNull] SpecParser.CharClassPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ConcatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcatPattern([NotNull] SpecParser.ConcatPatternContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ConcatPattern</c>
	/// labeled alternative in <see cref="SpecParser.pattern"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcatPattern([NotNull] SpecParser.ConcatPatternContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CharRange</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharRange([NotNull] SpecParser.CharRangeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CharRange</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharRange([NotNull] SpecParser.CharRangeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SingleChar</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleChar([NotNull] SpecParser.SingleCharContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SingleChar</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleChar([NotNull] SpecParser.SingleCharContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DashChar</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDashChar([NotNull] SpecParser.DashCharContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DashChar</c>
	/// labeled alternative in <see cref="SpecParser.charSet"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDashChar([NotNull] SpecParser.DashCharContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SpecParser.char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChar([NotNull] SpecParser.CharContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SpecParser.char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChar([NotNull] SpecParser.CharContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModeCommand([NotNull] SpecParser.ModeCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModeCommand([NotNull] SpecParser.ModeCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PushModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPushModeCommand([NotNull] SpecParser.PushModeCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PushModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPushModeCommand([NotNull] SpecParser.PushModeCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PopModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPopModeCommand([NotNull] SpecParser.PopModeCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PopModeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPopModeCommand([NotNull] SpecParser.PopModeCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SkipCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSkipCommand([NotNull] SpecParser.SkipCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SkipCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSkipCommand([NotNull] SpecParser.SkipCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeCommand([NotNull] SpecParser.TypeCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeCommand([NotNull] SpecParser.TypeCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ChannelCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChannelCommand([NotNull] SpecParser.ChannelCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ChannelCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChannelCommand([NotNull] SpecParser.ChannelCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ErrorCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorCommand([NotNull] SpecParser.ErrorCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ErrorCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorCommand([NotNull] SpecParser.ErrorCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CaptureCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaptureCommand([NotNull] SpecParser.CaptureCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CaptureCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaptureCommand([NotNull] SpecParser.CaptureCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DecodeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecodeCommand([NotNull] SpecParser.DecodeCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DecodeCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecodeCommand([NotNull] SpecParser.DecodeCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TextCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextCommand([NotNull] SpecParser.TextCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TextCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextCommand([NotNull] SpecParser.TextCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ActionCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterActionCommand([NotNull] SpecParser.ActionCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ActionCommand</c>
	/// labeled alternative in <see cref="SpecParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitActionCommand([NotNull] SpecParser.ActionCommandContext context);
}
} // namespace PreAdamant.Compiler.Tools.Lex
