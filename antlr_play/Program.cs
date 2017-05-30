using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Misc;

namespace antlr_play
{
    class AntlrDrinkListener : DrinkBaseListener
    {
        public override void EnterDrink([NotNull] DrinkParser.DrinkContext context)
        {
            System.Console.WriteLine("Drink = " + context.GetText());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String input = "a cup of tea";
            ICharStream stream = CharStreams.fromstring(input);
            ITokenSource lexer = new DrinkLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            DrinkParser parser = new DrinkParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.drinkSentence();
            AntlrDrinkListener printer = new AntlrDrinkListener();
            ParseTreeWalker.Default.Walk(printer, tree);
            System.Console.ReadLine();
        }
    }
}
