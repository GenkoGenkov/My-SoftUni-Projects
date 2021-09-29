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
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match item in matches)
            {
                Console.Write(item + " ");
            }
        }
    }
}