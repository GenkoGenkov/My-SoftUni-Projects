﻿using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    Console.Write(input[i]);
                }
            }

            Console.Write(input[input.Length - 1]);
        }  
    }
}
