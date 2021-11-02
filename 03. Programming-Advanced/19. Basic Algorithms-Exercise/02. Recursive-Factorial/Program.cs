using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factoriel = GetFactoriel(n);

            Console.WriteLine(factoriel);
        }

        private static int GetFactoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * GetFactoriel(n - 1);
        }
    }
}