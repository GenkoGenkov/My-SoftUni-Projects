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
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long greater = numbers.OrderByDescending(x => x = x).First();
                long sum = 0;

                while (greater != 0)
                {
                    sum += Math.Abs(greater % 10);
                    greater /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}

