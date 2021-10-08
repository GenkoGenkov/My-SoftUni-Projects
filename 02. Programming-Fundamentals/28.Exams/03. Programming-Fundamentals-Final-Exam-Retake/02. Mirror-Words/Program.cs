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
            List<string> correctWords = new List<string>();

            string pattern = @"([@|#])(?<word>[a-zA-Z]{3,})\1{2}(?<mirror>[a-zA-Z]{3,})\1";

            string input = Console.ReadLine();

            MatchCollection mirrorWords = Regex.Matches(input, pattern);

            foreach (Match item in mirrorWords)
            {
                string word = item.Groups["word"].Value;
                string mirror = item.Groups["mirror"].Value;
                string reversed = string.Join("", item.Groups["mirror"].Value.Reverse());

                if (word == reversed)
                {
                    correctWords.Add($"{word} <=> {mirror}");
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{mirrorWords.Count} word pairs found!");
            }

            if (correctWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", correctWords));
            }
        }
    }
}

