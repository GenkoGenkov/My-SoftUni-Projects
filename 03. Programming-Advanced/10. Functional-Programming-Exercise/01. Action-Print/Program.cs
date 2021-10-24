using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printCollection = input => Console.WriteLine(string.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine().Split();

            printCollection(input);
        }
    }
}