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

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputIntegers[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            int counter = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryDiagonal += matrix[i, counter];
                counter--;
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}

