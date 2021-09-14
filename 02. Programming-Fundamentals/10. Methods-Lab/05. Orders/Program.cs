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
            string order = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            SumOfOrders(order, n);
        }

        private static void SumOfOrders(string order, int n)
        {
            double sum = 0;

            if (order == "water")
            {
                sum = 1.00 * n;
            }
            else if (order == "coffee")
            {
                sum = 1.50 * n;
            }
            else if (order == "coke")
            {
                sum = 1.40 * n;
            }
            else if (order == "snacks")
            {
                sum = 2.00 * n;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}

