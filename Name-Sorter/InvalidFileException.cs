using System;
using System.Collections.Generic;
using System.Text;

namespace Name_Sorter
{
    //thrown exception for invalid file name
    public class InvalidFileException : System.Exception
    {
        public InvalidFileException() : base() { }
        public InvalidFileException(string message) : base(message) { }
        public InvalidFileException(string message, System.Exception inner) : base(message, inner) { }
    }
}
