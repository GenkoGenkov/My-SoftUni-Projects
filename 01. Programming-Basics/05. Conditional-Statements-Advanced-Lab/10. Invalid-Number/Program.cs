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
            int num = int.Parse(Console.ReadLine());

            if (num < 100 && num > 0)
            {
                Console.WriteLine("invalid");
            }
            else if (num > 200)
            {
                Console.WriteLine("invalid");
            }
            else if (num < 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
