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
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = Calculate(width, height);

            Console.WriteLine(result);
        }

        static double Calculate(double widht, double height)
        {
            return widht * height;
        }
    }
}

