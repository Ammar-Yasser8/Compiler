using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    // PHASE 4: EVALUATOR (Tree --> Result) 
    public class Evaluator
    {
        public int Evaluate(ExpressionNode node)
        {
            if (node is NumberNode n)
            {
                return n.Value;
            }

            if (node is BinaryExpressionNode b)
            {
                var left = Evaluate(b.Left);
                var right = Evaluate(b.Right);

                switch (b.Operator)
                {
                    case TokenType.Plus: return left + right;
                    case TokenType.Minus: return left - right;
                    case TokenType.Multiply: return left * right;
                    case TokenType.Divide: return left / right;
                    default: throw new Exception("Unknown operator");
                }
            }

            throw new Exception("Unknown node type");
        }
    }
}
