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
            double trunk = double.Parse(Console.ReadLine());

            double counterSuitcases = 0;

            while (true)
            {
                string suitcase = Console.ReadLine();

                if (suitcase == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }
                else
                {
                    double capacity = double.Parse(suitcase);
                    counterSuitcases++;

                    if (counterSuitcases % 3 == 0)
                    {
                        capacity += capacity * 0.1;
                    }

                    if (capacity > trunk)
                    {
                        counterSuitcases--;
                        Console.WriteLine("No more space!");
                        break;
                    }

                    trunk -= capacity;
                }

            }

            Console.WriteLine($"Statistic: {counterSuitcases} suitcases loaded.");
        }
    }
}

