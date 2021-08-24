using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string townName = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double finalPrice = 0;

            if (townName == "Sofia")
            {
                if (productName == "coffee")
                {
                    finalPrice = quantity * 0.50;
                }
                else if (productName == "water")
                {
                    finalPrice = quantity * 0.80;
                }
                else if (productName == "beer")
                {
                    finalPrice = quantity * 1.20;
                }
                else if (productName == "sweets")
                {
                    finalPrice = quantity * 1.45;
                }
                else if (productName == "peanuts")
                {
                    finalPrice = quantity * 1.60;
                }

            }
            else if (townName == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    finalPrice = quantity * 0.40;
                }
                else if (productName == "water")
                {
                    finalPrice = quantity * 0.70;
                }
                else if (productName == "beer")
                {
                    finalPrice = quantity * 1.15;
                }
                else if (productName == "sweets")
                {
                    finalPrice = quantity * 1.30;
                }
                else if (productName == "peanuts")
                {
                    finalPrice = quantity * 1.50;
                }

            }
            else if (townName == "Varna")
            {
                if (productName == "coffee")
                {
                    finalPrice = quantity * 0.45;
                }
                else if (productName == "water")
                {
                    finalPrice = quantity * 0.70;
                }
                else if (productName == "beer")
                {
                    finalPrice = quantity * 1.10;
                }
                else if (productName == "sweets")
                {
                    finalPrice = quantity * 1.35;
                }
                else if (productName == "peanuts")
                {
                    finalPrice = quantity * 1.55;
                }

            }

            Console.WriteLine(finalPrice);
        }
    }
}
