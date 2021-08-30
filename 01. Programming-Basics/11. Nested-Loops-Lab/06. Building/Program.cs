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
            int floorNumber = int.Parse(Console.ReadLine());
            int flatNumber = int.Parse(Console.ReadLine());

            for (int floor = floorNumber; floor >= 1; floor--)
            {
                for (int flat = 0; flat < flatNumber; flat++)
                {
                    if (floor == floorNumber)
                    {
                        Console.Write($"L{floor}{flat} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{flat} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{flat} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

