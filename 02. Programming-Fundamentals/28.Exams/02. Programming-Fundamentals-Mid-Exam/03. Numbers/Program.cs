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
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> top5 = new List<int>();

            double average = integers.Average();

            top5 = integers.Where(i => i > average).OrderByDescending(i => i).ToList();

            while (top5.Count > 5)
            {
                top5.RemoveAt(top5.Count - 1);
            }

            Console.WriteLine(top5.Count > 0 ? string.Join(" ", top5) : "No");
        }
    }
}

