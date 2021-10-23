using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbersWithVat = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2);

            foreach (var item in numbersWithVat)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
