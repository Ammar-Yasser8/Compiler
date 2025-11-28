# 🧮 MiniLang Web Compiler

<div align="center">

![.NET](https://img.shields.io/badge/.NET-8.0-purple?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-blue?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

*A modern, web-based mathematical expression interpreter built with ASP.NET Core MVC.*

[🚀 Quick Start](#-getting-started) • [📖 Documentation](#-architecture) • [✨ Features](#-features) • [🤝 Contributing](#-contributing)

</div>

---

## 📋 Overview

**MiniLang Web Compiler** is a robust mathematical expression evaluator wrapped in a premium web interface. It demonstrates core compiler design principles (Lexing, Parsing, Evaluation) within a modern ASP.NET Core MVC application.

### Why MiniLang?

- **Web-Based Interface**: Clean, responsive UI with light/dark mode support.
- **Visual Feedback**: Real-time evaluation with result type information.
- **Educational Core**: Pure C# implementation of a recursive descent parser.
- **Modern Stack**: Built on .NET 8 and ASP.NET Core MVC.

## ✨ Features

| Feature | Description |
|---------|-------------|
| 🌐 **Web Interface** | Premium UI with glassmorphism effects and responsive design |
| 🔤 **Tokenization** | Converts raw input into structured tokens |
| 🌳 **AST Generation** | Builds Abstract Syntax Trees using recursive descent parsing |
| ⚖️ **Operator Precedence** | Correctly handles mathematical order of operations |
| 🛡️ **Error Handling** | Comprehensive syntax error detection and reporting |
| 📊 **Type Inspection** | Displays the underlying AST node type for the result |

## 🏗️ Architecture

The application follows a clean separation of concerns:

### Compiler Core
1. **Lexer**: Scans input string -> Tokens
2. **Parser**: Tokens -> Abstract Syntax Tree (AST)
3. **Evaluator**: AST -> Result (int)

### Web Layer (MVC)
- **Controller**: Handles HTTP requests and orchestrates the compilation process.
- **Views**: Renders the UI using Razor syntax and modern CSS.
- **Models**: Transfers data (Input, Output, ResultType, Errors) between Controller and Views.

## 💻 Getting Started

### Prerequisites

- .NET SDK 8.0 or later
- A modern web browser

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Ammar-Yasser8/Compiler.git
   ```

2. Navigate to the project folder:
   ```bash
   cd Compiler
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

4. Open your browser to `http://localhost:5200`

## 🕹️ Usage

Enter mathematical expressions in the text area and click **Run Compiler**.

**Examples:**

- Basic Arithmetic: `10 + 5` -> `15`
- Precedence: `10 + 5 * 2` -> `20`
- Grouping: `(10 + 5) * 2` -> `30`
- Complex: `100 / 2 + 50 - (5 * 2)` -> `90`

The result will display the calculated value and the type of the root AST node (e.g., `BinaryExpressionNode`, `NumberNode`).

## 🔮 Future Roadmap

- [ ] Add support for Variables (e.g., `let x = 10`).
- [ ] Add support for Floating point numbers.
- [ ] Implement a history of recent evaluations.


