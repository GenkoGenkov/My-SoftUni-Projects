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
            string input = Console.ReadLine();
            double balance = 0.0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount >= 0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

            }

            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
