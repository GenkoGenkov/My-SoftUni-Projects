using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string message)
            : base(message)
        {
        }
    }
}
