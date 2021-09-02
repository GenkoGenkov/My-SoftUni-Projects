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
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double biscuits = 0;
            double catFoodPercent = 0;
            double dogFoodPercent = 0;


            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());

                dogFoodPercent = dogFoodPercent + dogFood;
                catFoodPercent = catFoodPercent + catFood;

                if (i % 3 == 0)
                {
                    double currentbiscuits = (dogFood + catFood) * 0.10;
                    biscuits += currentbiscuits;
                }
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{(catFoodPercent + dogFoodPercent) * 100 / food:F2}% of the food has been eaten.");
            Console.WriteLine($"{dogFoodPercent * 100 / (catFoodPercent + dogFoodPercent):F2}% eaten from the dog.");
            Console.WriteLine($"{catFoodPercent * 100 / (catFoodPercent + dogFoodPercent):F2}% eaten from the cat.");
        }
    }
}

