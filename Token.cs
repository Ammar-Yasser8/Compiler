using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    // PHASE 1: Tokens 
    // Token Type + Value of token

    public class Token
    {
        public TokenType Type { get; }
        public string Text { get; }
        public Token(TokenType type, string text)
        {
            Type = type;
            Text = text;
        }
        public override string ToString() => $"{Type}: {Text}";
    }
}
