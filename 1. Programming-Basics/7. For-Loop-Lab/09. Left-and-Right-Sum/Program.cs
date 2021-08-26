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


            int sumL = 0;
            int sumR = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumL += currentNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumR += currentNumber;
            }

            if (sumL == sumR)
            {
                Console.WriteLine($"Yes, sum = {sumL}");
            }
            else
            {
                int diff = Math.Abs(sumL - sumR);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
