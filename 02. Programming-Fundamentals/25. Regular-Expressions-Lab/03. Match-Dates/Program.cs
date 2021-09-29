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

            var matches = Regex.Matches(input, @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }
        }
    }
}