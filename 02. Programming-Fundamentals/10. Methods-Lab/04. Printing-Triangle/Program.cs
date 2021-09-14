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
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintCol(row);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrintCol(row);
            }
        }

        private static void PrintCol(int row)
        {
            for (int j = 1; j <= row; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

