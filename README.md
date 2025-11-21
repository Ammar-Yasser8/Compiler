# 🧮 Simple Mathematical Expression Interpreter in C#

<div align="center">

![.NET](https://img.shields.io/badge/.NET-10-blue?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)
![Build](https://img.shields.io/badge/Build-Passing-success?style=for-the-badge)

*A handcrafted mathematical expression interpreter built from scratch to explore compiler design fundamentals*

[🚀 Quick Start](#-getting-started) • [📖 Documentation](#-architecture) • [🎯 Examples](#-usage-examples) • [🤝 Contributing](#-contributing)

</div>

---

## 📋 Overview

**MiniLang Interpreter** is a lightweight, educational compiler and interpreter designed to evaluate mathematical expressions. Built entirely in C# without external parsing libraries, it demonstrates the core phases of compiler construction through clean, understandable code.

### Why MiniLang?

- **Educational Focus**: Perfect for learning compiler design principles
- **Zero Dependencies**: Pure C# implementation with no external parsing libraries
- **Clean Architecture**: Clear separation of lexical analysis, parsing, and evaluation
- **Production Patterns**: Implements industry-standard compiler techniques

## ✨ Features

| Feature | Description |
|---------|-------------|
| 🔤 **Tokenization** | Converts raw input into structured tokens |
| 🌳 **AST Generation** | Builds Abstract Syntax Trees using recursive descent parsing |
| ⚖️ **Operator Precedence** | Correctly handles mathematical order of operations |
| 🔗 **Parentheses Support** | Full support for nested expressions and grouping |
| 🛡️ **Error Handling** | Comprehensive syntax error detection and reporting |
| 🎯 **Type Safety** | Strong typing throughout the compilation pipeline |

## 🏗️ Architecture

The interpreter follows the classical compiler pipeline architecture:

graph LR
    A[Input Source] -->|Text| B(Lexer)
    B -->|Tokens| C(Parser)
    C -->|AST| D(Evaluator)
    D -->|Result| E[Output]


1. Lexer (Tokenizer)

Scans the input string character by character and groups them into Tokens.

Input: 10 + 5

Output: [Number(10), Plus, Number(5), EOF]

2. Parser (Syntax Analysis)

Uses Recursive Descent Parsing to organize tokens into a tree structure (AST) based on grammar rules. It handles operator precedence by separating logic into ParseExpression (lowest priority) and ParseTerm (highest priority).

Structure:

Expression: Handles +, -

Term: Handles *, /

Factor: Handles Numbers, ( )

3. Evaluator

Traverses the Abstract Syntax Tree (AST) recursively to compute the final result.

## 💻 Getting Started

### Prerequisites

- .NET SDK (6.0 or later)
- Visual Studio or VS Code

### Installation

1. Clone the repository:

   ```bash
   git clone [https://github.com/Ammar-Yasser8/compiler.git](https://github.com/Ammar-Yasser8/compiler.git)
   ```

2. Navigate to the project folder:

   ```bash
   cd compiler
   ```

3. Run the project:

   ```bash
   dotnet run
   ```

## 🕹️ Usage

Once the application is running, you can type mathematical expressions directly into the console:

```
> 10 + 5
Result: 15

> 10 + 5 * 2
Result: 20  (Note: Multiplication happened first!)

> (10 + 5) * 2
Result: 30

> 100 / 2 + 50
Result: 100
```

## 🔮 Future Roadmap

- [ ] Add support for Variables (e.g., x = 10).
- [ ] Add support for Floating point numbers (double).
- [ ] Add power operator (^).

