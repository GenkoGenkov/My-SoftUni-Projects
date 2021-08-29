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
            double dogs = double.Parse(Console.ReadLine());

            int otherAnimals = int.Parse(Console.ReadLine());

            Console.WriteLine($"{dogs * 2.50 + otherAnimals * 4} lv.");
        }
    }
}