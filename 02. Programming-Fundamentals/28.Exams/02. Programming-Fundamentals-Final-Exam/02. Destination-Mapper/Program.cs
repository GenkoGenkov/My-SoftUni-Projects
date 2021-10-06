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
            string pattern = @"([=|\/])(?<locations>[A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();

            MatchCollection countries = Regex.Matches(input, pattern);

            Console.WriteLine($"Destinations: {string.Join(", ", countries.Select(g => g.Groups["locations"].Value))}");
            Console.WriteLine($"Travel Points: {string.Join("", countries.Select(g => g.Groups["locations"].Value)).Length}");
        }
    }
}

