using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    // Second phase string ---> Tokens
    // Token Token(Token Type, Value of token)
    public class Lexer
    {
        private readonly string _text;
        private int _position;

        public Lexer(string text)
        {
            _text = text;
            _position = 0;
        }

        // Current character under examination 
        private char Current => _position >= _text.Length ? '\0' : _text[_position];
        

        private void Next() => _position++;

        public List<Token> Tokenize()
        {
            var tokens = new List<Token>();
            while (_position < _text.Length)
            {
                if (char.IsDigit(Current))
                {
                    tokens.Add(ReadNumber());
                }
                else if (char.IsWhiteSpace(Current))
                {
                    Next();
                }
                else if (Current == '+') { tokens.Add(new Token(TokenType.Plus, "+")); Next(); }
                else if (Current == '-') { tokens.Add(new Token(TokenType.Minus, "-")); Next(); }
                else if (Current == '*') { tokens.Add(new Token(TokenType.Multiply, "*")); Next(); }
                else if (Current == '/') { tokens.Add(new Token(TokenType.Divide, "/")); Next(); }
                else if (Current == '(') { tokens.Add(new Token(TokenType.LParen, "(")); Next(); }
                else if (Current == ')') { tokens.Add(new Token(TokenType.RParen, ")")); Next(); }
                else
                {
                    throw new Exception($"Unknown character: {Current}");
                }
            }
            tokens.Add(new Token(TokenType.EOF, ""));
            return tokens;
        }
        private Token ReadNumber()
        {
            int start = _position;
            while (char.IsDigit(Current))
                Next();

            string text = _text.Substring(start, _position - start);
            return new Token(TokenType.Number, text);
        }
    }

}
