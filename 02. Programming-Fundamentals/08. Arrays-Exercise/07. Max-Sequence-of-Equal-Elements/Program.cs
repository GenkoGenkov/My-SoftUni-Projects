using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxElements = 0;
            int currentEqualElements = 1;
            int element = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    currentEqualElements++;
                }
                else
                {
                    currentEqualElements = 1;
                }

                if (currentEqualElements > maxElements)
                {
                    maxElements = currentEqualElements;
                    element = input[i];
                }
            }

            for (int i = 0; i < maxElements; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}

