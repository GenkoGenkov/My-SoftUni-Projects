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
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(number, power);

            Console.WriteLine(result);
        }

        static double MathPower(double number, int power)
        {
            double resultOne = 1;

            for (int i = 0; i < power; i++)
            {
                resultOne *= number;
            }
            return resultOne;
        }
    }
}

