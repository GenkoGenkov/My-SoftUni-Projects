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
            string text = Console.ReadLine();

            string pattern = @"(?<match>(?<letters>[^\d]+)(?<digits>\d+))";

            MatchCollection matches = Regex.Matches(text, pattern);

            StringBuilder result = new StringBuilder();

            foreach (Match item in matches)
            {
                string symbolsToPrint = item.Groups["letters"].Value;

                int repeats = int.Parse(item.Groups["digits"].Value);

                for (int i = 0; i < repeats; i++)
                {
                    result.Append(symbolsToPrint.ToUpper());
                }
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}