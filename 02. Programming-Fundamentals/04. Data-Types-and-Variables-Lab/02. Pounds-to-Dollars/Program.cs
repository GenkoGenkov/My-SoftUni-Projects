﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * 1.31m;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}

