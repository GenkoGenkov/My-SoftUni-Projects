using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> printCollection = input => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", input));

            List<string> input = Console.ReadLine().Split().ToList();

            printCollection(input);
        }
    }
}