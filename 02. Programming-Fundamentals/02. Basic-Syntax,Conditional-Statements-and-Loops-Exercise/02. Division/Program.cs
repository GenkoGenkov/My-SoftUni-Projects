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
            int input = int.Parse(Console.ReadLine());

            int divisionNumber = 0;

            if (input % 10 == 0)
            {
                divisionNumber = 10;
            }
            else if (input % 7 == 0)
            {
                divisionNumber = 7;
            }
            else if (input % 6 == 0)
            {
                divisionNumber = 6;
            }
            else if (input % 3 == 0)
            {
                divisionNumber = 3;
            }
            else if (input % 2 == 0)
            {
                divisionNumber = 2;
            }

            if (divisionNumber == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else if (true)
            {
                Console.WriteLine($"The number is divisible by {divisionNumber}");
            }
        }
    }
}

