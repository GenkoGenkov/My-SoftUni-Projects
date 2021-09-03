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
            double budget = double.Parse(Console.ReadLine());
            int sumSerials = int.Parse(Console.ReadLine());

            double allSum = 0;

            for (int i = 0; i < sumSerials; i++)
            {
                string nameSerials = Console.ReadLine();
                double priceSerials = double.Parse(Console.ReadLine());

                switch (nameSerials)
                {
                    case "Thrones": priceSerials *= 0.50; break;
                    case "Lucifer": priceSerials *= 0.60; break;
                    case "Protector": priceSerials *= 0.70; break;
                    case "TotalDrama": priceSerials *= 0.80; break;
                    case "Area": priceSerials *= 0.90; break;

                }

                allSum += priceSerials;

            }

            if (budget >= allSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget - allSum:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {allSum - budget:F2} lv. more to buy the series!");
            }
        }
    }
}

