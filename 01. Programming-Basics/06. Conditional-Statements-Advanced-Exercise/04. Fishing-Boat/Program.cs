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
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double price = 0;


            if (season == "Spring")
            {
                price = 3000;

            }
            if (season == "Summer")
            {
                price = 4200;

            }

            if (season == "Autumn")
            {
                price = 4200;

            }
            if (season == "Winter")
            {
                price = 2600;
            }


            if (numberOfFishermen <= 6)
            {
                price *= 0.9;
            }
            else if (numberOfFishermen <= 11)
            {
                price *= 0.85;
            }
            else if (numberOfFishermen > 12)
            {
                price *= 0.75;
            }
            if (numberOfFishermen % 2 == 0)
            {
                if (season != "Autumn")
                {
                    price *= 0.95;
                }

            }

            if (budget >= price)
            {

                Console.WriteLine($"Yes! You have {(budget - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):F2} leva.");
            }
                
        }
    }
}
