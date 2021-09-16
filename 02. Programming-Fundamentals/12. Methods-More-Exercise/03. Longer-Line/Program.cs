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
            double xOne = double.Parse(Console.ReadLine());
            double yOne = double.Parse(Console.ReadLine());

            double xTwo = double.Parse(Console.ReadLine());
            double yTwo = double.Parse(Console.ReadLine());

            double xThree = double.Parse(Console.ReadLine());
            double yThree = double.Parse(Console.ReadLine());

            double xFour = double.Parse(Console.ReadLine());
            double yFour = double.Parse(Console.ReadLine());

            LongestLine(xOne, yOne, xTwo, yTwo, xThree, yThree, xFour, yFour);
        }

        private static void LongestLine(double xOne, double yOne, double xTwo, double yTwo, double xThree, double yThree, double xFour, double yFour)
        {
            double resultOne = Math.Abs(xOne) + Math.Abs(yOne) + Math.Abs(xTwo) + Math.Abs(yTwo);
            double resultTwo = Math.Abs(xThree) + Math.Abs(yThree) + Math.Abs(xFour) + Math.Abs(yFour);

            if (resultTwo > resultOne)
            {
                if (Math.Abs(xThree) + Math.Abs(yThree) > (Math.Abs(xFour) + Math.Abs(yFour)))
                {
                    Console.WriteLine($"({xFour}, {yFour})({xThree}, {yThree})");
                }
                else
                {
                    Console.WriteLine($"({xThree}, {yThree})({xFour}, {yFour})");
                }
            }
            else if ((Math.Abs(xOne) + Math.Abs(yOne)) > (Math.Abs(xTwo) + Math.Abs(yTwo)))
            {
                Console.WriteLine($"({xTwo}, {yTwo})({xOne}, {yOne})");
            }
            else
            {
                Console.WriteLine($"({xOne}, {yOne})({xTwo}, {yTwo})");
            }

        }
    }
}

