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
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double moneyFromAllToys = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);
            int toysCounter = puzzles + dolls + bears + minions + trucks;

            if (toysCounter >= 50)
            {
                moneyFromAllToys = moneyFromAllToys * 0.75;
            }

            double totalMoneyAfterRent = moneyFromAllToys * 0.9;

            if (totalMoneyAfterRent >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalMoneyAfterRent - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice - totalMoneyAfterRent):f2} lv needed.");
            }
        }
    }
}
