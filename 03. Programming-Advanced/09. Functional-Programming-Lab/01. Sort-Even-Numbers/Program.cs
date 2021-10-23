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
            IOrderedEnumerable<int> newList = Console.ReadLine().Split(',').Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x);

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
