using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            int symbolRow = 0;
            int symbolCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        symbolRow = row;
                        symbolCol = col;

                        Console.WriteLine($"({symbolRow}, {symbolCol})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}


