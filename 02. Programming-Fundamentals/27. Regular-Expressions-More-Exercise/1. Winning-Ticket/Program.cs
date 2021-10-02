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
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string patternTicket = @"([$#@^])\1{5,9}";

            foreach (var item in tickets)
            {

                if (item.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string left = item.Substring(0, 10);
                string right = item.Substring(10, 10);

                Match leftCollection = Regex.Match(left, patternTicket);
                Match rightCollection = Regex.Match(right, patternTicket);

                int minLen = Math.Min(leftCollection.Length, rightCollection.Length);

                if (!leftCollection.Success || !rightCollection.Success)
                {
                    Console.WriteLine($"ticket \"{item}\" - no match");
                    continue;
                }

                string leftMatch = leftCollection.Value.Substring(0, minLen);
                string rightMatch = rightCollection.Value.Substring(0, minLen);

                if (leftMatch.Length >= 6 && leftMatch.Length <= 9 && leftMatch.Equals(rightMatch))
                {
                    Console.WriteLine($"ticket \"{item}\" - {leftMatch.Length}{leftMatch[0]}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{item}\" - {leftMatch.Length}{leftMatch[0]} Jackpot!");
                }

            }
        }
    }
}