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
            double result = double.Parse(Console.ReadLine());

            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
