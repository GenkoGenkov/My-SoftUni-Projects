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

            double sumHonorar = 0;
            double actorHonorar = 0;

            while (sumHonorar <= budget)
            {
                string actorName = Console.ReadLine();

                if (actorName != "ACTION")
                {
                    int lenghtName = actorName.Length;

                    if (lenghtName > 15)
                    {
                        actorHonorar = (budget - sumHonorar) * 0.2;
                        sumHonorar += actorHonorar;
                    }
                    else
                    {
                        actorHonorar = double.Parse(Console.ReadLine());
                        sumHonorar += actorHonorar;
                    }
                }
                else if (actorName == "ACTION")
                {
                    break;
                }
            }

            if (sumHonorar <= budget)
            {
                Console.WriteLine($"We are left with {budget - sumHonorar:F2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {sumHonorar - budget:F2} leva for our actors.");
            }
        }
    }
}

