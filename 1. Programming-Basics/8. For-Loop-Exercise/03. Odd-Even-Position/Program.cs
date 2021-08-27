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
            int n = int.Parse(Console.ReadLine());

            double evenSum = 0;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;

            double oddSum = 0;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNumber;

                    if (currentNumber < minEven)
                    {
                        minEven = currentNumber;
                    }

                    if (currentNumber > maxEven)
                    {
                        maxEven = currentNumber;
                    }
                }
                else
                {
                    oddSum += currentNumber;

                    if (currentNumber > maxOdd)
                    {
                        maxOdd = currentNumber;
                    }

                    if (currentNumber < minOdd)
                    {
                        minOdd = currentNumber;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");

            if (minOdd != double.MaxValue)
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (minEven != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
