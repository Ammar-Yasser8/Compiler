using Compiler;
using System.Diagnostics.Metrics;

while (true)
{
    Console.Write("Enter you code : ");
    string line = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(line)) return;

    try
    {
        // Phase 1 & 2: LEXER
        var lexer = new Lexer(line);
        var tokens = lexer.Tokenize();


        // phase 3: PARSER
        var parser = new Parser(tokens);
        var expression = parser.Parse();

        // phase 4: Evaluator ---->  (Interpreter)
        var evaluator = new Evaluator();
        var result = evaluator.Evaluate(expression);

        Console.WriteLine($"Result: {result}");

        // Visualizing the tree (Optional)
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"[Type]: {expression.GetType().Name}");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error: {ex.Message}");
        Console.ResetColor();
    }
}