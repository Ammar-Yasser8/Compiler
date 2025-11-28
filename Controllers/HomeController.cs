using Compiler.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Compiler.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new EvaluationResult());
    }

    [HttpPost]
    public IActionResult Index(string code)
    {
        var model = new EvaluationResult { Input = code };

        if (string.IsNullOrWhiteSpace(code))
        {
            model.Error = "Please enter some code.";
            return View(model);
        }

        try
        {
            // Phase 1 & 2: LEXER
            var lexer = new Lexer(code);
            var tokens = lexer.Tokenize();

            // phase 3: PARSER
            var parser = new Parser(tokens);
            var expression = parser.Parse();

            // phase 4: Evaluator ---->  (Interpreter)
            var evaluator = new Evaluator();
            var result = evaluator.Evaluate(expression);

            model.Output = $"{result} [Type]: {expression.GetType().Name}";
            model.ResultType = expression.GetType().Name;
            model.Success = true;
        }
        catch (Exception ex)
        {
            model.Error = ex.Message;
            model.Success = false;
        }

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class ErrorViewModel
{
    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
