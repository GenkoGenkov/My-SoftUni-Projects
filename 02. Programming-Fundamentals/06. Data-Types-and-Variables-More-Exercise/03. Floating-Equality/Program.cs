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
            double eps = 0.000001;
            double n1 = 0.0;
            double n2 = 0.0;


            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(n1 - n2) < eps;

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

