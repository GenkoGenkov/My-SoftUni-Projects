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
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    break;
                }
            }

            Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}

