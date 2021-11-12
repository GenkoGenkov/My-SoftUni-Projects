using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - 1 - i) + (string.Join(" ", new string('*', i + 1).ToCharArray())));
            }

            for (var u = n - 2; u >= 0; u--)
            {
                Console.WriteLine(new string(' ', n - 1 - u) + (string.Join(" ", new string('*', u + 1).ToCharArray())));
            }
        }
    }
}