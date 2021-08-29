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
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                ++sum;

                if (currentNumber % 2 == 0)
                {
                    ++p1;
                }

                if (currentNumber % 3 == 0)
                {
                    ++p2;
                }

                if (currentNumber % 4 == 0)
                {
                    ++p3;
                }
            }

            Console.WriteLine("{0:F2}%", 100 * p1 / sum);
            Console.WriteLine("{0:F2}%", 100 * p2 / sum);
            Console.WriteLine("{0:F2}%", 100 * p3 / sum);
        }
    }
}
