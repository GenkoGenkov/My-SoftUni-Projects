﻿using System;
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
            int n = int.Parse(Console.ReadLine());
            int[] divNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] allNumbers = Enumerable.Range(1, n).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var number in divNumbers)
            {
                predicates.Add(x => x % number == 0);
            }

            foreach (var currentNumber in allNumbers)
            {
                bool isDivisible = true;

                foreach (var item in predicates)
                {
                    if (!item(currentNumber))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}