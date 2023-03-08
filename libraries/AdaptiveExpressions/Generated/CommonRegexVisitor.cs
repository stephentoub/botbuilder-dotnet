//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CommonRegex.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


#pragma warning disable 3021 // Disable StyleCop warning CS3021 re CLSCompliant attribute in generated files.
#pragma warning disable 0108 // Disable StyleCop warning CS0108, hides inherited member in generated files.

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CommonRegexParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface ICommonRegexVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse([NotNull] CommonRegexParser.ParseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.alternation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlternation([NotNull] CommonRegexParser.AlternationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] CommonRegexParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElement([NotNull] CommonRegexParser.ElementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.quantifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantifier([NotNull] CommonRegexParser.QuantifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.quantifier_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQuantifier_type([NotNull] CommonRegexParser.Quantifier_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.character_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharacter_class([NotNull] CommonRegexParser.Character_classContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCapture([NotNull] CommonRegexParser.CaptureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.non_capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNon_capture([NotNull] CommonRegexParser.Non_captureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption([NotNull] CommonRegexParser.OptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.option_flag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOption_flag([NotNull] CommonRegexParser.Option_flagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAtom([NotNull] CommonRegexParser.AtomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.cc_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCc_atom([NotNull] CommonRegexParser.Cc_atomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.shared_atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShared_atom([NotNull] CommonRegexParser.Shared_atomContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] CommonRegexParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.cc_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCc_literal([NotNull] CommonRegexParser.Cc_literalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.shared_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShared_literal([NotNull] CommonRegexParser.Shared_literalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] CommonRegexParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.octal_char"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOctal_char([NotNull] CommonRegexParser.Octal_charContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.octal_digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOctal_digit([NotNull] CommonRegexParser.Octal_digitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.digits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDigits([NotNull] CommonRegexParser.DigitsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.digit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDigit([NotNull] CommonRegexParser.DigitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] CommonRegexParser.NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.alpha_nums"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlpha_nums([NotNull] CommonRegexParser.Alpha_numsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.non_close_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNon_close_parens([NotNull] CommonRegexParser.Non_close_parensContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.non_close_paren"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNon_close_paren([NotNull] CommonRegexParser.Non_close_parenContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CommonRegexParser.letter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetter([NotNull] CommonRegexParser.LetterContext context);
}
