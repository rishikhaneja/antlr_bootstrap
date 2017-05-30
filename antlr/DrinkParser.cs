//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Drink.g by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class DrinkParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		ARTICLE=1, OF=2, DRINKING_VESSEL=3, TEXT=4, WHITESPACE=5;
	public const int
		RULE_drinkSentence = 0, RULE_drink = 1;
	public static readonly string[] ruleNames = {
		"drinkSentence", "drink"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'of'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "ARTICLE", "OF", "DRINKING_VESSEL", "TEXT", "WHITESPACE"
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

	public override string GrammarFileName { get { return "Drink.g"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DrinkParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DrinkParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DrinkParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class DrinkSentenceContext : ParserRuleContext {
		public ITerminalNode DRINKING_VESSEL() { return GetToken(DrinkParser.DRINKING_VESSEL, 0); }
		public ITerminalNode OF() { return GetToken(DrinkParser.OF, 0); }
		public DrinkContext drink() {
			return GetRuleContext<DrinkContext>(0);
		}
		public ITerminalNode ARTICLE() { return GetToken(DrinkParser.ARTICLE, 0); }
		public DrinkSentenceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_drinkSentence; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDrinkListener typedListener = listener as IDrinkListener;
			if (typedListener != null) typedListener.EnterDrinkSentence(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDrinkListener typedListener = listener as IDrinkListener;
			if (typedListener != null) typedListener.ExitDrinkSentence(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDrinkVisitor<TResult> typedVisitor = visitor as IDrinkVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDrinkSentence(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DrinkSentenceContext drinkSentence() {
		DrinkSentenceContext _localctx = new DrinkSentenceContext(Context, State);
		EnterRule(_localctx, 0, RULE_drinkSentence);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 5;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==ARTICLE) {
				{
				State = 4; Match(ARTICLE);
				}
			}

			State = 7; Match(DRINKING_VESSEL);
			State = 8; Match(OF);
			State = 9; drink();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DrinkContext : ParserRuleContext {
		public ITerminalNode TEXT() { return GetToken(DrinkParser.TEXT, 0); }
		public DrinkContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_drink; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDrinkListener typedListener = listener as IDrinkListener;
			if (typedListener != null) typedListener.EnterDrink(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDrinkListener typedListener = listener as IDrinkListener;
			if (typedListener != null) typedListener.ExitDrink(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDrinkVisitor<TResult> typedVisitor = visitor as IDrinkVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDrink(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DrinkContext drink() {
		DrinkContext _localctx = new DrinkContext(Context, State);
		EnterRule(_localctx, 2, RULE_drink);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 11; Match(TEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\a', '\x10', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x3', '\x2', '\x5', '\x2', '\b', '\n', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x2', '\x2', '\x4', '\x2', '\x4', '\x2', '\x2', '\x2', 
		'\xE', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x4', '\r', '\x3', '\x2', 
		'\x2', '\x2', '\x6', '\b', '\a', '\x3', '\x2', '\x2', '\a', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '\a', '\b', '\x3', '\x2', '\x2', '\x2', '\b', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\t', '\n', '\a', '\x5', '\x2', '\x2', '\n', 
		'\v', '\a', '\x4', '\x2', '\x2', '\v', '\f', '\x5', '\x4', '\x3', '\x2', 
		'\f', '\x3', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\a', '\x6', '\x2', 
		'\x2', '\xE', '\x5', '\x3', '\x2', '\x2', '\x2', '\x3', '\a',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
