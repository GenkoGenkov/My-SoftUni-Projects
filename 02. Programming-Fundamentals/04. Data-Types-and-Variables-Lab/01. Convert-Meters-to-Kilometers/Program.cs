using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal metres = decimal.Parse(Console.ReadLine());

            decimal kilometres = metres / 1000;

            Console.WriteLine($"{kilometres:F2}");
        }
    }
}

