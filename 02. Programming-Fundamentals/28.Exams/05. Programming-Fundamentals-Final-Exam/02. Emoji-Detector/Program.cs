using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([:*]){2}([A-Z][a-z]{2,})\1{2}";

            long coolThreshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    coolThreshold *= input[i] - 48;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match item in matches)
            {
                int coolness = 0;
                string emoji = item.Groups[2].Value;

                for (int i = 0; i < emoji.Length; i++)
                {
                    coolness += emoji[i];
                }

                if (coolness >= coolThreshold)
                {
                    Console.WriteLine(item.Value);
                }

            }
        }
    }
}
