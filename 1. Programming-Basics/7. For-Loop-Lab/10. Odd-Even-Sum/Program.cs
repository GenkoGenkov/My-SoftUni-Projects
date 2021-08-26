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

            int oddNumbers = 0;
            int evenNumbers = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddNumbers += currentNumber;
                }
                else if (i % 2 == 0)
                {
                    evenNumbers += currentNumber;
                }

            }
            int diff = Math.Abs(oddNumbers - evenNumbers);

            if (oddNumbers == evenNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumbers}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
