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
            int nPower = int.Parse(Console.ReadLine());
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaustion = int.Parse(Console.ReadLine());

            int halfOfN = nPower / 2;
            int targets = 0;

            while (nPower >= mDistance)
            {
                targets++;
                nPower -= mDistance;

                if (halfOfN == nPower && yExhaustion > 0)
                {
                    nPower /= yExhaustion;
                }

            }

            Console.WriteLine(nPower);
            Console.WriteLine(targets);
        }
    }
}

