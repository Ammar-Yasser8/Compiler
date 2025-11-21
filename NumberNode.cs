using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    public class NumberNode : ExpressionNode
    {
        public int Value { get; }
        public NumberNode(int value) 
        { 
            Value = value; 
        }
    }
}
