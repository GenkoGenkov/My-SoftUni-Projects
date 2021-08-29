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
            double vacationMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spendCounter = 0;

            while (spendCounter != 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (input == "save")
                {
                    currentMoney += money;
                    spendCounter = 0;
                }
                else if (input == "spend")
                {
                    spendCounter++;

                    if (money > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= money;
                    }
                }

                if (currentMoney >= vacationMoney)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    return;
                }
            }

            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{days}");
        }
    }
}
