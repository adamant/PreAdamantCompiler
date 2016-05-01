//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from PreprocessorLineLexer.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace PreAdamant.Compiler.Lexer.Preprocessor {
using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class PreprocessorLineLexer : Lexer {
	public const int
		SingleLineComment=1, Define=2, Undefine=3, If=4, ElseIf=5, Else=6, EndIf=7, 
		Line=8, Error=9, Warning=10, Region=11, EndRegion=12, PragmaWarning=13, 
		Pragma=14, BooleanLiteral=15, LineMode=16, WarningAction=17, ConditionalSymbol=18, 
		And=19, Or=20, Not=21, Equal=22, NotEqual=23, LeftParen=24, RightParen=25, 
		Number=26, FileName=27, Comma=28, Whitespace=29, Newline=30, Message=31;
	public const int MESSAGE = 1;
	public static string[] modeNames = {
		"DEFAULT_MODE", "MESSAGE"
	};

	public static readonly string[] ruleNames = {
		"SingleLineComment", "Define", "Undefine", "If", "ElseIf", "Else", "EndIf", 
		"Line", "Error", "Warning", "Region", "EndRegion", "PragmaWarning", "Pragma", 
		"BooleanLiteral", "LineMode", "WarningAction", "ConditionalSymbol", "And", 
		"Or", "Not", "Equal", "NotEqual", "LeftParen", "RightParen", "Number", 
		"FileName", "FileNameChar", "Comma", "Whitespace", "WhitespaceChar", "Newline", 
		"InputChar", "IdentifierStartChar", "IdentifierPartChar", "LetterChar", 
		"DigitChar", "ConnectingChar", "CombiningChar", "FormattingChar", "UnicodeEscape", 
		"HexDigit", "DecimalDigit", "Unicode_Zs", "Unicode_Lu", "Unicode_Ll", 
		"Unicode_Lt", "Unicode_Lm", "Unicode_Lo", "Unicode_Nl", "Unicode_Mn", 
		"Unicode_Mc", "Unicode_Cf", "Unicode_Pc", "Unicode_Nd", "Message"
	};


	public PreprocessorLineLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, "'&&'", "'||'", "'!'", "'=='", 
		"'!='", "'('", "')'", null, null, "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SingleLineComment", "Define", "Undefine", "If", "ElseIf", "Else", 
		"EndIf", "Line", "Error", "Warning", "Region", "EndRegion", "PragmaWarning", 
		"Pragma", "BooleanLiteral", "LineMode", "WarningAction", "ConditionalSymbol", 
		"And", "Or", "Not", "Equal", "NotEqual", "LeftParen", "RightParen", "Number", 
		"FileName", "Comma", "Whitespace", "Newline", "Message"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "PreprocessorLineLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2!\x20B\b\x1\b\x1"+
		"\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b"+
		"\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF"+
		"\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37"+
		"\t\x37\x4\x38\t\x38\x4\x39\t\x39\x3\x2\x3\x2\x3\x2\x3\x2\a\x2y\n\x2\f"+
		"\x2\xE\x2|\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\x5\x3\x82\n\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x5\x4\x8D\n\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x5\x5\x9A\n\x5\x3"+
		"\x5\x3\x5\x3\x5\x3\x6\x3\x6\x5\x6\xA1\n\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\a\x3\a\x5\a\xAC\n\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3"+
		"\b\x5\b\xB5\n\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x5\t\xBF\n\t\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x5\n\xC8\n\n\x3\n\x3\n\x3\n\x3\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\v\x3\v\x5\v\xD4\n\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\f\x3\f\x5\f\xE2\n\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f"+
		"\x3\f\x3\f\x3\f\x3\r\x3\r\x5\r\xEF\n\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3"+
		"\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x5\xE\xFF\n\xE\x3\xE\x3\xE\x3"+
		"\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE"+
		"\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x5\xF\x115\n\xF\x3\xF\x3\xF\x3\xF"+
		"\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x5\x10\x129\n\x10\x3\x11\x3\x11\x3\x11\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x5"+
		"\x11\x138\n\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x5\x12\x148\n\x12\x3\x13\x3"+
		"\x13\a\x13\x14C\n\x13\f\x13\xE\x13\x14F\v\x13\x3\x14\x3\x14\x3\x14\x3"+
		"\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x6\x1B\x164\n\x1B\r\x1B\xE\x1B"+
		"\x165\x3\x1C\x3\x1C\x6\x1C\x16A\n\x1C\r\x1C\xE\x1C\x16B\x3\x1C\x3\x1C"+
		"\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x6\x1F\x175\n\x1F\r\x1F\xE\x1F\x176"+
		"\x3\x1F\x3\x1F\x3 \x3 \x5 \x17D\n \x3!\x3!\x3!\x3!\x5!\x183\n!\x3!\x3"+
		"!\x3\"\x3\"\x3#\x3#\x3#\x5#\x18C\n#\x3$\x3$\x3$\x3$\x3$\x3$\x5$\x194\n"+
		"$\x3%\x3%\x3%\x3%\x3%\x3%\x5%\x19C\n%\x3&\x3&\x3\'\x3\'\x3(\x3(\x5(\x1A4"+
		"\n(\x3)\x3)\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3"+
		"*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*"+
		"\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3"+
		"*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x5*\x1E9"+
		"\n*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3\x31\x3\x31"+
		"\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3\x36\x3\x36"+
		"\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x6\x39\x208\n\x39\r\x39\xE\x39\x209"+
		"\x2\x2:\x4\x3\x6\x4\b\x5\n\x6\f\a\xE\b\x10\t\x12\n\x14\v\x16\f\x18\r\x1A"+
		"\xE\x1C\xF\x1E\x10 \x11\"\x12$\x13&\x14(\x15*\x16,\x17.\x18\x30\x19\x32"+
		"\x1A\x34\x1B\x36\x1C\x38\x1D:\x2<\x1E>\x1F@\x2\x42 \x44\x2\x46\x2H\x2"+
		"J\x2L\x2N\x2P\x2R\x2T\x2V\x2X\x2Z\x2\\\x2^\x2`\x2\x62\x2\x64\x2\x66\x2"+
		"h\x2j\x2l\x2n\x2p\x2r!\x4\x2\x3\x12\x3\x2$$\x4\x2\v\v\r\xE\x4\x2\f\f\xF"+
		"\xF\x4\x2\x87\x87\x202A\x202B\x6\x2\f\f\xF\xF\x87\x87\x202A\x202B\x5\x2"+
		"\x32;\x43H\x63h\x3\x2\x32;\n\x2\"\"\xA2\xA2\x1682\x1682\x1810\x1810\x2002"+
		"\x200C\x2031\x2031\x2061\x2061\x3002\x3002\x5\x2\x43\\\xC2\xE0\x393\x39C"+
		"\x4\x2\x63|\x3B3\x3CB\x6\x2\x1C7\x1C7\x1CA\x1CA\x1CD\x1CD\x1F4\x1F4\x5"+
		"\x2\x1BD\x1BD\x1C2\x1C5\x296\x296\x4\x2\x16F0\x16F2\x2162\x2171\x5\x2"+
		"\x905\x905\x940\x942\x94B\x94E\x5\x2\xAF\xAF\x602\x605\x6DF\x6DF\b\x2"+
		"\x61\x61\x2041\x2042\x2056\x2056\xFE35\xFE36\xFE4F\xFE51\xFF41\xFF41\x21C"+
		"\x2\x4\x3\x2\x2\x2\x2\x6\x3\x2\x2\x2\x2\b\x3\x2\x2\x2\x2\n\x3\x2\x2\x2"+
		"\x2\f\x3\x2\x2\x2\x2\xE\x3\x2\x2\x2\x2\x10\x3\x2\x2\x2\x2\x12\x3\x2\x2"+
		"\x2\x2\x14\x3\x2\x2\x2\x2\x16\x3\x2\x2\x2\x2\x18\x3\x2\x2\x2\x2\x1A\x3"+
		"\x2\x2\x2\x2\x1C\x3\x2\x2\x2\x2\x1E\x3\x2\x2\x2\x2 \x3\x2\x2\x2\x2\"\x3"+
		"\x2\x2\x2\x2$\x3\x2\x2\x2\x2&\x3\x2\x2\x2\x2(\x3\x2\x2\x2\x2*\x3\x2\x2"+
		"\x2\x2,\x3\x2\x2\x2\x2.\x3\x2\x2\x2\x2\x30\x3\x2\x2\x2\x2\x32\x3\x2\x2"+
		"\x2\x2\x34\x3\x2\x2\x2\x2\x36\x3\x2\x2\x2\x2\x38\x3\x2\x2\x2\x2<\x3\x2"+
		"\x2\x2\x2>\x3\x2\x2\x2\x2\x42\x3\x2\x2\x2\x3r\x3\x2\x2\x2\x4t\x3\x2\x2"+
		"\x2\x6\x7F\x3\x2\x2\x2\b\x8A\x3\x2\x2\x2\n\x97\x3\x2\x2\x2\f\x9E\x3\x2"+
		"\x2\x2\xE\xA9\x3\x2\x2\x2\x10\xB2\x3\x2\x2\x2\x12\xBC\x3\x2\x2\x2\x14"+
		"\xC5\x3\x2\x2\x2\x16\xD1\x3\x2\x2\x2\x18\xDF\x3\x2\x2\x2\x1A\xEC\x3\x2"+
		"\x2\x2\x1C\xFC\x3\x2\x2\x2\x1E\x112\x3\x2\x2\x2 \x128\x3\x2\x2\x2\"\x137"+
		"\x3\x2\x2\x2$\x147\x3\x2\x2\x2&\x149\x3\x2\x2\x2(\x150\x3\x2\x2\x2*\x153"+
		"\x3\x2\x2\x2,\x156\x3\x2\x2\x2.\x158\x3\x2\x2\x2\x30\x15B\x3\x2\x2\x2"+
		"\x32\x15E\x3\x2\x2\x2\x34\x160\x3\x2\x2\x2\x36\x163\x3\x2\x2\x2\x38\x167"+
		"\x3\x2\x2\x2:\x16F\x3\x2\x2\x2<\x171\x3\x2\x2\x2>\x174\x3\x2\x2\x2@\x17C"+
		"\x3\x2\x2\x2\x42\x182\x3\x2\x2\x2\x44\x186\x3\x2\x2\x2\x46\x18B\x3\x2"+
		"\x2\x2H\x193\x3\x2\x2\x2J\x19B\x3\x2\x2\x2L\x19D\x3\x2\x2\x2N\x19F\x3"+
		"\x2\x2\x2P\x1A3\x3\x2\x2\x2R\x1A5\x3\x2\x2\x2T\x1E8\x3\x2\x2\x2V\x1EA"+
		"\x3\x2\x2\x2X\x1EC\x3\x2\x2\x2Z\x1EE\x3\x2\x2\x2\\\x1F0\x3\x2\x2\x2^\x1F2"+
		"\x3\x2\x2\x2`\x1F4\x3\x2\x2\x2\x62\x1F6\x3\x2\x2\x2\x64\x1F8\x3\x2\x2"+
		"\x2\x66\x1FA\x3\x2\x2\x2h\x1FC\x3\x2\x2\x2j\x1FE\x3\x2\x2\x2l\x200\x3"+
		"\x2\x2\x2n\x202\x3\x2\x2\x2p\x204\x3\x2\x2\x2r\x207\x3\x2\x2\x2tu\a\x31"+
		"\x2\x2uv\a\x31\x2\x2vz\x3\x2\x2\x2wy\x5\x44\"\x2xw\x3\x2\x2\x2y|\x3\x2"+
		"\x2\x2zx\x3\x2\x2\x2z{\x3\x2\x2\x2{}\x3\x2\x2\x2|z\x3\x2\x2\x2}~\b\x2"+
		"\x2\x2~\x5\x3\x2\x2\x2\x7F\x81\a%\x2\x2\x80\x82\x5>\x1F\x2\x81\x80\x3"+
		"\x2\x2\x2\x81\x82\x3\x2\x2\x2\x82\x83\x3\x2\x2\x2\x83\x84\a\x66\x2\x2"+
		"\x84\x85\ag\x2\x2\x85\x86\ah\x2\x2\x86\x87\ak\x2\x2\x87\x88\ap\x2\x2\x88"+
		"\x89\ag\x2\x2\x89\a\x3\x2\x2\x2\x8A\x8C\a%\x2\x2\x8B\x8D\x5>\x1F\x2\x8C"+
		"\x8B\x3\x2\x2\x2\x8C\x8D\x3\x2\x2\x2\x8D\x8E\x3\x2\x2\x2\x8E\x8F\aw\x2"+
		"\x2\x8F\x90\ap\x2\x2\x90\x91\a\x66\x2\x2\x91\x92\ag\x2\x2\x92\x93\ah\x2"+
		"\x2\x93\x94\ak\x2\x2\x94\x95\ap\x2\x2\x95\x96\ag\x2\x2\x96\t\x3\x2\x2"+
		"\x2\x97\x99\a%\x2\x2\x98\x9A\x5>\x1F\x2\x99\x98\x3\x2\x2\x2\x99\x9A\x3"+
		"\x2\x2\x2\x9A\x9B\x3\x2\x2\x2\x9B\x9C\ak\x2\x2\x9C\x9D\ah\x2\x2\x9D\v"+
		"\x3\x2\x2\x2\x9E\xA0\a%\x2\x2\x9F\xA1\x5>\x1F\x2\xA0\x9F\x3\x2\x2\x2\xA0"+
		"\xA1\x3\x2\x2\x2\xA1\xA2\x3\x2\x2\x2\xA2\xA3\ag\x2\x2\xA3\xA4\an\x2\x2"+
		"\xA4\xA5\au\x2\x2\xA5\xA6\ag\x2\x2\xA6\xA7\ak\x2\x2\xA7\xA8\ah\x2\x2\xA8"+
		"\r\x3\x2\x2\x2\xA9\xAB\a%\x2\x2\xAA\xAC\x5>\x1F\x2\xAB\xAA\x3\x2\x2\x2"+
		"\xAB\xAC\x3\x2\x2\x2\xAC\xAD\x3\x2\x2\x2\xAD\xAE\ag\x2\x2\xAE\xAF\an\x2"+
		"\x2\xAF\xB0\au\x2\x2\xB0\xB1\ag\x2\x2\xB1\xF\x3\x2\x2\x2\xB2\xB4\a%\x2"+
		"\x2\xB3\xB5\x5>\x1F\x2\xB4\xB3\x3\x2\x2\x2\xB4\xB5\x3\x2\x2\x2\xB5\xB6"+
		"\x3\x2\x2\x2\xB6\xB7\ag\x2\x2\xB7\xB8\ap\x2\x2\xB8\xB9\a\x66\x2\x2\xB9"+
		"\xBA\ak\x2\x2\xBA\xBB\ah\x2\x2\xBB\x11\x3\x2\x2\x2\xBC\xBE\a%\x2\x2\xBD"+
		"\xBF\x5>\x1F\x2\xBE\xBD\x3\x2\x2\x2\xBE\xBF\x3\x2\x2\x2\xBF\xC0\x3\x2"+
		"\x2\x2\xC0\xC1\an\x2\x2\xC1\xC2\ak\x2\x2\xC2\xC3\ap\x2\x2\xC3\xC4\ag\x2"+
		"\x2\xC4\x13\x3\x2\x2\x2\xC5\xC7\a%\x2\x2\xC6\xC8\x5>\x1F\x2\xC7\xC6\x3"+
		"\x2\x2\x2\xC7\xC8\x3\x2\x2\x2\xC8\xC9\x3\x2\x2\x2\xC9\xCA\ag\x2\x2\xCA"+
		"\xCB\at\x2\x2\xCB\xCC\at\x2\x2\xCC\xCD\aq\x2\x2\xCD\xCE\at\x2\x2\xCE\xCF"+
		"\x3\x2\x2\x2\xCF\xD0\b\n\x3\x2\xD0\x15\x3\x2\x2\x2\xD1\xD3\a%\x2\x2\xD2"+
		"\xD4\x5>\x1F\x2\xD3\xD2\x3\x2\x2\x2\xD3\xD4\x3\x2\x2\x2\xD4\xD5\x3\x2"+
		"\x2\x2\xD5\xD6\ay\x2\x2\xD6\xD7\a\x63\x2\x2\xD7\xD8\at\x2\x2\xD8\xD9\a"+
		"p\x2\x2\xD9\xDA\ak\x2\x2\xDA\xDB\ap\x2\x2\xDB\xDC\ai\x2\x2\xDC\xDD\x3"+
		"\x2\x2\x2\xDD\xDE\b\v\x3\x2\xDE\x17\x3\x2\x2\x2\xDF\xE1\a%\x2\x2\xE0\xE2"+
		"\x5>\x1F\x2\xE1\xE0\x3\x2\x2\x2\xE1\xE2\x3\x2\x2\x2\xE2\xE3\x3\x2\x2\x2"+
		"\xE3\xE4\at\x2\x2\xE4\xE5\ag\x2\x2\xE5\xE6\ai\x2\x2\xE6\xE7\ak\x2\x2\xE7"+
		"\xE8\aq\x2\x2\xE8\xE9\ap\x2\x2\xE9\xEA\x3\x2\x2\x2\xEA\xEB\b\f\x3\x2\xEB"+
		"\x19\x3\x2\x2\x2\xEC\xEE\a%\x2\x2\xED\xEF\x5>\x1F\x2\xEE\xED\x3\x2\x2"+
		"\x2\xEE\xEF\x3\x2\x2\x2\xEF\xF0\x3\x2\x2\x2\xF0\xF1\ag\x2\x2\xF1\xF2\a"+
		"p\x2\x2\xF2\xF3\a\x66\x2\x2\xF3\xF4\at\x2\x2\xF4\xF5\ag\x2\x2\xF5\xF6"+
		"\ai\x2\x2\xF6\xF7\ak\x2\x2\xF7\xF8\aq\x2\x2\xF8\xF9\ap\x2\x2\xF9\xFA\x3"+
		"\x2\x2\x2\xFA\xFB\b\r\x3\x2\xFB\x1B\x3\x2\x2\x2\xFC\xFE\a%\x2\x2\xFD\xFF"+
		"\x5>\x1F\x2\xFE\xFD\x3\x2\x2\x2\xFE\xFF\x3\x2\x2\x2\xFF\x100\x3\x2\x2"+
		"\x2\x100\x101\ar\x2\x2\x101\x102\at\x2\x2\x102\x103\a\x63\x2\x2\x103\x104"+
		"\ai\x2\x2\x104\x105\ao\x2\x2\x105\x106\a\x63\x2\x2\x106\x107\x3\x2\x2"+
		"\x2\x107\x108\x5>\x1F\x2\x108\x109\ay\x2\x2\x109\x10A\a\x63\x2\x2\x10A"+
		"\x10B\at\x2\x2\x10B\x10C\ap\x2\x2\x10C\x10D\ak\x2\x2\x10D\x10E\ap\x2\x2"+
		"\x10E\x10F\ai\x2\x2\x10F\x110\x3\x2\x2\x2\x110\x111\x5>\x1F\x2\x111\x1D"+
		"\x3\x2\x2\x2\x112\x114\a%\x2\x2\x113\x115\x5>\x1F\x2\x114\x113\x3\x2\x2"+
		"\x2\x114\x115\x3\x2\x2\x2\x115\x116\x3\x2\x2\x2\x116\x117\ar\x2\x2\x117"+
		"\x118\at\x2\x2\x118\x119\a\x63\x2\x2\x119\x11A\ai\x2\x2\x11A\x11B\ao\x2"+
		"\x2\x11B\x11C\a\x63\x2\x2\x11C\x11D\x3\x2\x2\x2\x11D\x11E\b\xF\x3\x2\x11E"+
		"\x1F\x3\x2\x2\x2\x11F\x120\av\x2\x2\x120\x121\at\x2\x2\x121\x122\aw\x2"+
		"\x2\x122\x129\ag\x2\x2\x123\x124\ah\x2\x2\x124\x125\a\x63\x2\x2\x125\x126"+
		"\an\x2\x2\x126\x127\au\x2\x2\x127\x129\ag\x2\x2\x128\x11F\x3\x2\x2\x2"+
		"\x128\x123\x3\x2\x2\x2\x129!\x3\x2\x2\x2\x12A\x12B\a\x66\x2\x2\x12B\x12C"+
		"\ag\x2\x2\x12C\x12D\ah\x2\x2\x12D\x12E\a\x63\x2\x2\x12E\x12F\aw\x2\x2"+
		"\x12F\x130\an\x2\x2\x130\x138\av\x2\x2\x131\x132\aj\x2\x2\x132\x133\a"+
		"k\x2\x2\x133\x134\a\x66\x2\x2\x134\x135\a\x66\x2\x2\x135\x136\ag\x2\x2"+
		"\x136\x138\ap\x2\x2\x137\x12A\x3\x2\x2\x2\x137\x131\x3\x2\x2\x2\x138#"+
		"\x3\x2\x2\x2\x139\x13A\a\x66\x2\x2\x13A\x13B\ak\x2\x2\x13B\x13C\au\x2"+
		"\x2\x13C\x13D\a\x63\x2\x2\x13D\x13E\a\x64\x2\x2\x13E\x13F\an\x2\x2\x13F"+
		"\x148\ag\x2\x2\x140\x141\at\x2\x2\x141\x142\ag\x2\x2\x142\x143\au\x2\x2"+
		"\x143\x144\av\x2\x2\x144\x145\aq\x2\x2\x145\x146\at\x2\x2\x146\x148\a"+
		"g\x2\x2\x147\x139\x3\x2\x2\x2\x147\x140\x3\x2\x2\x2\x148%\x3\x2\x2\x2"+
		"\x149\x14D\x5\x46#\x2\x14A\x14C\x5H$\x2\x14B\x14A\x3\x2\x2\x2\x14C\x14F"+
		"\x3\x2\x2\x2\x14D\x14B\x3\x2\x2\x2\x14D\x14E\x3\x2\x2\x2\x14E\'\x3\x2"+
		"\x2\x2\x14F\x14D\x3\x2\x2\x2\x150\x151\a(\x2\x2\x151\x152\a(\x2\x2\x152"+
		")\x3\x2\x2\x2\x153\x154\a~\x2\x2\x154\x155\a~\x2\x2\x155+\x3\x2\x2\x2"+
		"\x156\x157\a#\x2\x2\x157-\x3\x2\x2\x2\x158\x159\a?\x2\x2\x159\x15A\a?"+
		"\x2\x2\x15A/\x3\x2\x2\x2\x15B\x15C\a#\x2\x2\x15C\x15D\a?\x2\x2\x15D\x31"+
		"\x3\x2\x2\x2\x15E\x15F\a*\x2\x2\x15F\x33\x3\x2\x2\x2\x160\x161\a+\x2\x2"+
		"\x161\x35\x3\x2\x2\x2\x162\x164\x5X,\x2\x163\x162\x3\x2\x2\x2\x164\x165"+
		"\x3\x2\x2\x2\x165\x163\x3\x2\x2\x2\x165\x166\x3\x2\x2\x2\x166\x37\x3\x2"+
		"\x2\x2\x167\x169\a$\x2\x2\x168\x16A\x5:\x1D\x2\x169\x168\x3\x2\x2\x2\x16A"+
		"\x16B\x3\x2\x2\x2\x16B\x169\x3\x2\x2\x2\x16B\x16C\x3\x2\x2\x2\x16C\x16D"+
		"\x3\x2\x2\x2\x16D\x16E\a$\x2\x2\x16E\x39\x3\x2\x2\x2\x16F\x170\n\x2\x2"+
		"\x2\x170;\x3\x2\x2\x2\x171\x172\a.\x2\x2\x172=\x3\x2\x2\x2\x173\x175\x5"+
		"@ \x2\x174\x173\x3\x2\x2\x2\x175\x176\x3\x2\x2\x2\x176\x174\x3\x2\x2\x2"+
		"\x176\x177\x3\x2\x2\x2\x177\x178\x3\x2\x2\x2\x178\x179\b\x1F\x2\x2\x179"+
		"?\x3\x2\x2\x2\x17A\x17D\x5Z-\x2\x17B\x17D\t\x3\x2\x2\x17C\x17A\x3\x2\x2"+
		"\x2\x17C\x17B\x3\x2\x2\x2\x17D\x41\x3\x2\x2\x2\x17E\x183\t\x4\x2\x2\x17F"+
		"\x180\a\xF\x2\x2\x180\x183\a\f\x2\x2\x181\x183\t\x5\x2\x2\x182\x17E\x3"+
		"\x2\x2\x2\x182\x17F\x3\x2\x2\x2\x182\x181\x3\x2\x2\x2\x183\x184\x3\x2"+
		"\x2\x2\x184\x185\b!\x2\x2\x185\x43\x3\x2\x2\x2\x186\x187\n\x6\x2\x2\x187"+
		"\x45\x3\x2\x2\x2\x188\x18C\x5J%\x2\x189\x18C\a\x61\x2\x2\x18A\x18C\x5"+
		"T*\x2\x18B\x188\x3\x2\x2\x2\x18B\x189\x3\x2\x2\x2\x18B\x18A\x3\x2\x2\x2"+
		"\x18CG\x3\x2\x2\x2\x18D\x194\x5J%\x2\x18E\x194\x5L&\x2\x18F\x194\x5N\'"+
		"\x2\x190\x194\x5P(\x2\x191\x194\x5R)\x2\x192\x194\x5T*\x2\x193\x18D\x3"+
		"\x2\x2\x2\x193\x18E\x3\x2\x2\x2\x193\x18F\x3\x2\x2\x2\x193\x190\x3\x2"+
		"\x2\x2\x193\x191\x3\x2\x2\x2\x193\x192\x3\x2\x2\x2\x194I\x3\x2\x2\x2\x195"+
		"\x19C\x5\\.\x2\x196\x19C\x5^/\x2\x197\x19C\x5`\x30\x2\x198\x19C\x5\x62"+
		"\x31\x2\x199\x19C\x5\x64\x32\x2\x19A\x19C\x5\x66\x33\x2\x19B\x195\x3\x2"+
		"\x2\x2\x19B\x196\x3\x2\x2\x2\x19B\x197\x3\x2\x2\x2\x19B\x198\x3\x2\x2"+
		"\x2\x19B\x199\x3\x2\x2\x2\x19B\x19A\x3\x2\x2\x2\x19CK\x3\x2\x2\x2\x19D"+
		"\x19E\x5p\x38\x2\x19EM\x3\x2\x2\x2\x19F\x1A0\x5n\x37\x2\x1A0O\x3\x2\x2"+
		"\x2\x1A1\x1A4\x5h\x34\x2\x1A2\x1A4\x5j\x35\x2\x1A3\x1A1\x3\x2\x2\x2\x1A3"+
		"\x1A2\x3\x2\x2\x2\x1A4Q\x3\x2\x2\x2\x1A5\x1A6\x5l\x36\x2\x1A6S\x3\x2\x2"+
		"\x2\x1A7\x1A8\a^\x2\x2\x1A8\x1A9\aw\x2\x2\x1A9\x1AA\x3\x2\x2\x2\x1AA\x1AB"+
		"\x5V+\x2\x1AB\x1AC\x5V+\x2\x1AC\x1AD\x5V+\x2\x1AD\x1AE\x5V+\x2\x1AE\x1E9"+
		"\x3\x2\x2\x2\x1AF\x1B0\a^\x2\x2\x1B0\x1B1\aw\x2\x2\x1B1\x1B2\a*\x2\x2"+
		"\x1B2\x1B3\x3\x2\x2\x2\x1B3\x1B4\x5V+\x2\x1B4\x1B5\a+\x2\x2\x1B5\x1E9"+
		"\x3\x2\x2\x2\x1B6\x1B7\a^\x2\x2\x1B7\x1B8\aw\x2\x2\x1B8\x1B9\a*\x2\x2"+
		"\x1B9\x1BA\x3\x2\x2\x2\x1BA\x1BB\x5V+\x2\x1BB\x1BC\x5V+\x2\x1BC\x1BD\a"+
		"+\x2\x2\x1BD\x1E9\x3\x2\x2\x2\x1BE\x1BF\a^\x2\x2\x1BF\x1C0\aw\x2\x2\x1C0"+
		"\x1C1\a*\x2\x2\x1C1\x1C2\x3\x2\x2\x2\x1C2\x1C3\x5V+\x2\x1C3\x1C4\x5V+"+
		"\x2\x1C4\x1C5\x5V+\x2\x1C5\x1C6\a+\x2\x2\x1C6\x1E9\x3\x2\x2\x2\x1C7\x1C8"+
		"\a^\x2\x2\x1C8\x1C9\aw\x2\x2\x1C9\x1CA\a*\x2\x2\x1CA\x1CB\x3\x2\x2\x2"+
		"\x1CB\x1CC\x5V+\x2\x1CC\x1CD\x5V+\x2\x1CD\x1CE\x5V+\x2\x1CE\x1CF\x5V+"+
		"\x2\x1CF\x1D0\a+\x2\x2\x1D0\x1E9\x3\x2\x2\x2\x1D1\x1D2\a^\x2\x2\x1D2\x1D3"+
		"\aw\x2\x2\x1D3\x1D4\a*\x2\x2\x1D4\x1D5\x3\x2\x2\x2\x1D5\x1D6\x5V+\x2\x1D6"+
		"\x1D7\x5V+\x2\x1D7\x1D8\x5V+\x2\x1D8\x1D9\x5V+\x2\x1D9\x1DA\x5V+\x2\x1DA"+
		"\x1DB\a+\x2\x2\x1DB\x1E9\x3\x2\x2\x2\x1DC\x1DD\a^\x2\x2\x1DD\x1DE\aw\x2"+
		"\x2\x1DE\x1DF\a*\x2\x2\x1DF\x1E0\x3\x2\x2\x2\x1E0\x1E1\x5V+\x2\x1E1\x1E2"+
		"\x5V+\x2\x1E2\x1E3\x5V+\x2\x1E3\x1E4\x5V+\x2\x1E4\x1E5\x5V+\x2\x1E5\x1E6"+
		"\x5V+\x2\x1E6\x1E7\a+\x2\x2\x1E7\x1E9\x3\x2\x2\x2\x1E8\x1A7\x3\x2\x2\x2"+
		"\x1E8\x1AF\x3\x2\x2\x2\x1E8\x1B6\x3\x2\x2\x2\x1E8\x1BE\x3\x2\x2\x2\x1E8"+
		"\x1C7\x3\x2\x2\x2\x1E8\x1D1\x3\x2\x2\x2\x1E8\x1DC\x3\x2\x2\x2\x1E9U\x3"+
		"\x2\x2\x2\x1EA\x1EB\t\a\x2\x2\x1EBW\x3\x2\x2\x2\x1EC\x1ED\t\b\x2\x2\x1ED"+
		"Y\x3\x2\x2\x2\x1EE\x1EF\t\t\x2\x2\x1EF[\x3\x2\x2\x2\x1F0\x1F1\t\n\x2\x2"+
		"\x1F1]\x3\x2\x2\x2\x1F2\x1F3\t\v\x2\x2\x1F3_\x3\x2\x2\x2\x1F4\x1F5\t\f"+
		"\x2\x2\x1F5\x61\x3\x2\x2\x2\x1F6\x1F7\x4\x2B2\x2F0\x2\x1F7\x63\x3\x2\x2"+
		"\x2\x1F8\x1F9\t\r\x2\x2\x1F9\x65\x3\x2\x2\x2\x1FA\x1FB\t\xE\x2\x2\x1FB"+
		"g\x3\x2\x2\x2\x1FC\x1FD\x4\x302\x312\x2\x1FDi\x3\x2\x2\x2\x1FE\x1FF\t"+
		"\xF\x2\x2\x1FFk\x3\x2\x2\x2\x200\x201\t\x10\x2\x2\x201m\x3\x2\x2\x2\x202"+
		"\x203\t\x11\x2\x2\x203o\x3\x2\x2\x2\x204\x205\x4\x32;\x2\x205q\x3\x2\x2"+
		"\x2\x206\x208\x5\x44\"\x2\x207\x206\x3\x2\x2\x2\x208\x209\x3\x2\x2\x2"+
		"\x209\x207\x3\x2\x2\x2\x209\x20A\x3\x2\x2\x2\x20As\x3\x2\x2\x2!\x2\x3"+
		"z\x81\x8C\x99\xA0\xAB\xB4\xBE\xC7\xD3\xE1\xEE\xFE\x114\x128\x137\x147"+
		"\x14D\x165\x16B\x176\x17C\x182\x18B\x193\x19B\x1A3\x1E8\x209\x4\b\x2\x2"+
		"\x4\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace PreAdamant.Compiler.Lexer.Preprocessor
