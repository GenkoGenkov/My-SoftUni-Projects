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

            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>[0-9]+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            double sum = 0;

            while (input != "end of shift")
            {
                string name = string.Empty;
                string product = string.Empty;
                int count = 0;
                double price = 0;
                double total = 0;

                MatchCollection equals = Regex.Matches(input, pattern);

                foreach (Match item in equals)
                {
                    name = item.Groups["name"].Value;
                    product = item.Groups["product"].Value;
                    count = int.Parse(item.Groups["count"].Value);
                    price = double.Parse(item.Groups["price"].Value);
                }

                total = price * count;
                sum += total;

                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine($"{name}: {product} - {total:F2}");
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}