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

            long factorielOfA = GetFactoriel(a);
            long factorielOfB = GetFactoriel(b);

            double result = (double)factorielOfA / factorielOfB;

            Console.WriteLine($"{result:F2}");
        }

        private static long GetFactoriel(int a)
        {
            long result = 1;

            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}

