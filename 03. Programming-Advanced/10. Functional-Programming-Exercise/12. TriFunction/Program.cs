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
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isLargerOrEqual = (name, asciiSum) => name.Sum(x => x) >= asciiSum;

            Func<List<string>, int, Func<string, int, bool>, string> desiredName = (allNames, number, func) => allNames.FirstOrDefault(x => func(x, number));

            string newName = desiredName(names, n, isLargerOrEqual);

            Console.WriteLine(newName);
        }
    }
}