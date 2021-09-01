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
            double bagsOverTwenty = double.Parse(Console.ReadLine());
            double bagsWeight = double.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int bagsCounter = int.Parse(Console.ReadLine());

            double taxes = 0;

            if (bagsWeight < 10)
            {
                taxes = bagsOverTwenty * 0.20;
            }
            else if (bagsWeight <= 20)
            {
                taxes = bagsOverTwenty * 0.50;
            }
            else
            {
                taxes = bagsOverTwenty;
            }


            if (daysLeft > 30)
            {
                taxes *= 1.10;
            }
            else if (daysLeft >= 7)
            {
                taxes *= 1.15;
            }
            else if (daysLeft < 7)
            {
                taxes *= 1.40;
            }

            double total = taxes * bagsCounter;

            Console.WriteLine($"The total price of bags is: {total:F2} lv.");
        }
    }
}

