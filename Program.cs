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


// Test cases:
// Category A: The Basics (Sanity Checks) 
/*
Input      Expected Result, Why?
1 + 2,3    Basic Addition
10 - 4,6   Basic Subtraction
5 * 6,30   Basic Multiplication
20 / 4,5   Basic Division
0 + 5,5    Zero handling

*/

// Category B: Operator Precedence
/*
 Input           Expected Result, Why?
2 + 3 * 4,        14              Multiplication before Addition (3*4=12; 2+12=14)
(1 + 2) * 3,      9               Parentheses first (1+2=3; 3*3=9)
4 + 5 * 2 - 3,    11              Mixed operations (5*2=10; 4+10=14; 14-3=11)
10 - 2 / 2,       9               Division before Subtraction (2/2=1; 10-1=9)
*/


// Category C: Edge Cases and Error Handling
/*
Input,          Expected Result, Why?
10 +            Error, Unexpected End of File (Parser expected a number after +).
10 + a          Error, Unknown Character (Lexer doesn't know 'a').
(10 + 5         Error, Missing closing parenthesis ).
10 / 0          Error, Divide by Zero exception (C# runtime error).
*/

//// STILL NO FLOAT SUPPORT 