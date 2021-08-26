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
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double singleToyPrice = double.Parse(Console.ReadLine());

            int toysCounter = 0;
            double moneyHolder = 0;
            int stolenMoney = 0;
            double moneyPresent = 10;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if (currentYear % 2 != 0)
                {
                    toysCounter++;
                }
                else
                {
                    stolenMoney++;
                    moneyHolder += moneyPresent;
                    moneyPresent += 10;
                }
            }

            double moneyFromToys = toysCounter * singleToyPrice;
            double finalResult = (moneyHolder + moneyFromToys) - stolenMoney;

            if (finalResult >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(finalResult - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - finalResult):f2}");
            }
        }
    }
}
