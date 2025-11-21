using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    public class BinaryExpressionNode : ExpressionNode
    {
        public ExpressionNode Left { get; }
        public ExpressionNode Right { get; }
        public TokenType Operator { get; }

        public BinaryExpressionNode(ExpressionNode left, TokenType op, ExpressionNode right)
        {
            Left = left;
            Operator = op;
            Right = right;
        }
    }
}
