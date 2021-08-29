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
            double km = double.Parse(Console.ReadLine());

            double finalPrice = km * 7.61;
            double discount = 0.18 * finalPrice;
            double final = finalPrice - discount;

            Console.WriteLine($"The final price is: {final}");
            Console.WriteLine($"The discount is: {discount}");
        }
    }
}