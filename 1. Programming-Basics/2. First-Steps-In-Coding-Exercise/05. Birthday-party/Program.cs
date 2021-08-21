using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            double hallRent = double.Parse(Console.ReadLine());

            double cakePrice = hallRent * 0.20;

            double drinksPrice = cakePrice - cakePrice * 0.45;

            double animatorPrice = hallRent / 3;

            double total = hallRent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(total);
        }
    }
}