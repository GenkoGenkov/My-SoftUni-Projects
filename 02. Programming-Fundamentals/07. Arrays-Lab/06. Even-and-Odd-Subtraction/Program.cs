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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbers = 0;
            int oddNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    oddNumbers += currentNumber;
                }
            }

            Console.WriteLine(evenNumbers - oddNumbers);
        }
    }
}

