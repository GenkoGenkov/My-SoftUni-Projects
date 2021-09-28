using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            int min = Math.Min(first, second);
            int max = Math.Max(first, second);
            int sum = 0;

            StringBuilder text = new StringBuilder(Console.ReadLine());

            foreach (var item in text.ToString())
            {
                if (item > min && item < max)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}