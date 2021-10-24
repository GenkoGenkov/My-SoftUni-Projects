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
            Func<int, int, bool> isDivisble = (n, m) => n % m == 0;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divNumber = int.Parse(Console.ReadLine());

            int[] result = numbers.Where(x => !isDivisble(x, divNumber)).Reverse().ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}