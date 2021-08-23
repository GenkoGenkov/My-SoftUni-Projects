using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int mutesNumber = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * movieBudget;
            double totalClothingPrice = clothingPrice * mutesNumber;

            if (mutesNumber > 150)
            {
                totalClothingPrice = totalClothingPrice - (0.10 * totalClothingPrice);
            }

            double totalMoney = totalClothingPrice + decorPrice;
            double moneyLeft = movieBudget - totalMoney;

            if (totalMoney > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):f2} leva more.");
            }
            else if (totalMoney <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
