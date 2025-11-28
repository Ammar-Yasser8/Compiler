namespace Compiler.Models;

public class EvaluationResult
{
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? ResultType { get; set; }
    public string? Error { get; set; }
    public bool Success { get; set; }
}
