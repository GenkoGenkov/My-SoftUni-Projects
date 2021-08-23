using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string firstMeasureUnit = Console.ReadLine();
            string secondMeasureUnit = Console.ReadLine();


            double mm = 1000;
            double cm = 100;
            double result = 0.0;

            if (firstMeasureUnit == "m")
            {
                if (secondMeasureUnit == "cm")
                {
                    result = input * cm;
                    Console.WriteLine($"{result:f3}");
                }
                else if (secondMeasureUnit == "mm")
                {
                    result = input * mm;
                    Console.WriteLine($"{result:f3}");
                }
            }
            if (firstMeasureUnit == "cm")
            {
                if (secondMeasureUnit == "m")
                {
                    result = input / cm;
                    Console.WriteLine($"{result:f3}");
                }
                else if (secondMeasureUnit == "mm")
                {
                    result = input * 10;
                    Console.WriteLine($"{result:f3}");
                }
            }
            else if (firstMeasureUnit == "mm")
            {
                if (secondMeasureUnit == "cm")
                {
                    result = input / 10;
                    Console.WriteLine($"{result:f3}");
                }
                else if (secondMeasureUnit == "m")
                {
                    result = input / mm;
                    Console.WriteLine($"{result:f3}");
                }
            }
        }
    }
}
