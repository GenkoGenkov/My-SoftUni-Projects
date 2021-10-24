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
            Func<int[], int> getSmallestNumber = numbers =>
            {
                int minvalue = int.MaxValue;

                foreach (var item in numbers)
                {
                    if (item < minvalue)
                    {
                        minvalue = item;
                    }
                }

                return minvalue;
            };

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(getSmallestNumber(inputNumbers));
        }
    }
}