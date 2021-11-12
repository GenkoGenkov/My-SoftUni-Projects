using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            string season = input[2].ToLower();
            string discountType = "none";

            if (input.Length > 3) discountType = input[3].ToLower();

            decimal totalPrice = PriceCalculator.CalculatePrice(pricePerDay,numberOfDays,
                Enum.Parse<Season>(season),
                Enum.Parse<Discount>(discountType));

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}