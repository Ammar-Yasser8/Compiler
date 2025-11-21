using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    // Third phase: Tokens ---> Expression Tree
    public class Parser
    {
        private readonly List<Token> _tokens;
        private int _position;

        public Parser(List<Token> tokens)
        {
            _tokens = tokens;
            _position = 0;
        }

        private Token Current => _tokens[_position];

        private Token Match(TokenType type)
        {
            if (Current.Type == type)
            {
                var token = Current;
                _position++;
                return token;
            }
            throw new Exception($"Unexpected token <{Current.Type}>, expected <{type}>");
        }

        public ExpressionNode Parse()
        {
            return ParseExpression();
        }

        // Handles + and -
        private ExpressionNode ParseExpression()
        {
            var left = ParseTerm();

            while (Current.Type == TokenType.Plus || Current.Type == TokenType.Minus)
            {
                var operatorToken = Current;
                _position++;
                var right = ParseTerm();
                left = new BinaryExpressionNode(left, operatorToken.Type, right);
            }

            return left;
        }

        // Handles * and / (Higher precedence)
        private ExpressionNode ParseTerm()
        {
            var left = ParseFactor();

            while (Current.Type == TokenType.Multiply || Current.Type == TokenType.Divide)
            {
                var operatorToken = Current;
                _position++;
                var right = ParseFactor();
                left = new BinaryExpressionNode(left, operatorToken.Type, right);
            }

            return left;
        }

        // Handles Numbers and Parentheses
        private ExpressionNode ParseFactor()
        {
            if (Current.Type == TokenType.Number)
            {
                var token = Match(TokenType.Number);
                return new NumberNode(int.Parse(token.Text));
            }
            else if (Current.Type == TokenType.LParen)
            {
                _position++;
                var expression = ParseExpression();
                Match(TokenType.RParen);
                return expression;
            }

            throw new Exception($"Unexpected token: {Current.Type}");
        }
    }
}
