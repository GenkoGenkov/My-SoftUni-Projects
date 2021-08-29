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
            int lenght = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int cakePices = lenght * wight;

            while (cakePices > 0)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }

                int peaceOFCake = int.Parse(input);
                cakePices -= peaceOFCake;
            }

            if (cakePices >= 0)
            {
                Console.WriteLine($"{cakePices} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePices)} pieces more.");
            }
        }
    }
}
