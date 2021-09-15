using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = SmallestNumber(a, b, c);

            Console.WriteLine(result);
        }

        static int SmallestNumber(int a, int b, int c)
        {
            int minNumber = b;

            if (a < b)
            {
                minNumber = a;
            }

            if (c < minNumber)
            {
                minNumber = c;
            }

            return minNumber;
        }
    }
}

