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

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DrinkParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IDrinkListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DrinkParser.drinkSentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrinkSentence([NotNull] DrinkParser.DrinkSentenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DrinkParser.drinkSentence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrinkSentence([NotNull] DrinkParser.DrinkSentenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DrinkParser.drink"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrink([NotNull] DrinkParser.DrinkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DrinkParser.drink"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrink([NotNull] DrinkParser.DrinkContext context);
}
