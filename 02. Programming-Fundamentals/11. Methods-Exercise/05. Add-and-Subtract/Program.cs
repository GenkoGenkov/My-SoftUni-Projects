﻿using System;
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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int result = Subtract(sum, c);

            Console.WriteLine(result);
        }

        private static int Subtract(int sum, int c)
        {
            int result = sum - c;

            return result;
        }

        private static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }
    }
}

