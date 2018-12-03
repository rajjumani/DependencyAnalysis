using Tokenizer;
using System;
namespace Semi
{
    class Parser
    {
        public void parse()
        {
            Console.Write("This is Parser class");
            SemiExpression.get();
            // parsing of semi expression
        }
    }
    class Toker { 
        Console.Write("Toker Class");
    }
}