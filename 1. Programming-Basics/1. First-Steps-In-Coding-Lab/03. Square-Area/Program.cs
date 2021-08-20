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
            int side = int.Parse(Console.ReadLine());

            int sum = side * side;

            Console.WriteLine(sum);
        }
    }
}