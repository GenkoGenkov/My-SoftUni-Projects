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
            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }
            }

            int diff = sum - maxNum;

            if (diff == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int result = Math.Abs(diff - maxNum);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + result);

            }
        }
    }
}
