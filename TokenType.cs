using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{

    public enum TokenType
    {
        Number,
        Plus,
        Minus,
        Multiply,
        Divide,
        LParen,
        RParen,
        EOF // End of File
    }
}
