using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            double inch = double.Parse(Console.ReadLine());

            double sant = 2.54;

            double sum = inch * sant;

            Console.WriteLine(sum);
        }
    }
}