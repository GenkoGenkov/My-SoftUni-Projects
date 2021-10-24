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
            Action<int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }
            };

            Action<int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }
            };

            Action<int[]> smultiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }
            };

            Action<int[]> printNumbers = numbers => Console.WriteLine(string.Join(" ", numbers));

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {

                if (command == "add")
                {
                    add(inputNumbers);
                }
                else if (command == "multiply")
                {
                    smultiply(inputNumbers);
                }
                else if (command == "subtract")
                {
                    subtract(inputNumbers);
                }
                else if (command == "print")
                {
                    printNumbers(inputNumbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}