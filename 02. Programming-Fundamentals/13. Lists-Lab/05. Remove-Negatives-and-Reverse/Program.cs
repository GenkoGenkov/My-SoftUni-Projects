using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            foreach (var element in numbers)
            {
                if (element > 0)
                {
                    result.Add(element);
                }

            }

            result.Reverse();

            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else if (true)
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}

