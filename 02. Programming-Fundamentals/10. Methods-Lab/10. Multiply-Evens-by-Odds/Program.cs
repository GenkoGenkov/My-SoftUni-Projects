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
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int even = GetSumOfEvenDigits(number);
            int odd = GetSumOfOddDigits(number);

            Console.WriteLine(even * odd);
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }

            return sum;
        }
    }
}

