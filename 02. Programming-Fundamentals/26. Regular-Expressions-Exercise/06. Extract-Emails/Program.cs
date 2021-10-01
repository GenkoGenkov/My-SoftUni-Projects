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
            string mailPattern = @"(?<=\s)([A-Za-z0-9]+[-._]*[A-Za-z0-9]+)@([A-Za-z]+(([-.]*)[A-Za-z]+)*\.[a-z]{2,})";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, mailPattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}