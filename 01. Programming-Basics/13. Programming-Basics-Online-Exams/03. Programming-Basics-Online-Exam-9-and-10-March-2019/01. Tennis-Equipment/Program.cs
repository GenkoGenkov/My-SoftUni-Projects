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
            double priceForOneRocket = double.Parse(Console.ReadLine());
            int rocketsCounter = int.Parse(Console.ReadLine());
            int shoesCounter = int.Parse(Console.ReadLine());

            double totalForRockets = priceForOneRocket * rocketsCounter;
            double priceForShoes = priceForOneRocket / 6;
            double totalForShoes = priceForShoes * shoesCounter;
            double extraEquioment = (totalForRockets + totalForShoes) * 0.2;
            double total = totalForRockets + totalForShoes + extraEquioment;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(total / 8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(total * 7 / 8)}");
        }
    }
}

