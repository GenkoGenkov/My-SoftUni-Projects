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
            double radius = double.Parse(Console.ReadLine());

            double degrees = radius * 180 / Math.PI;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}