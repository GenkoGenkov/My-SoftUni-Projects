using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var myStack = new StackOfStrings();

            Console.WriteLine(myStack.IsEmpty());
            Console.WriteLine(myStack.IsEmpty());
        }
    }
}