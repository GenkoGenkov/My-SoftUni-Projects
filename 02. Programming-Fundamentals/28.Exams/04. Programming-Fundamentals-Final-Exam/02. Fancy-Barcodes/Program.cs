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
            string pattern = @"^@#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@#+$";
            string digitsPattern = "[0-9]";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                MatchCollection barcodes = Regex.Matches(input, digitsPattern);

                Console.Write("Product group: ");

                if (barcodes.Count == 0)
                {
                    Console.WriteLine("00");
                    continue;
                }

                foreach (Match item in barcodes)
                {
                    Console.Write(item.Value);
                }

                Console.WriteLine();
            }
        }
    }
}

