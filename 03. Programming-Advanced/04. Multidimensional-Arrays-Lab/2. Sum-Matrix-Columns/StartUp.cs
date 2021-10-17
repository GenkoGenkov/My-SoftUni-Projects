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
            string firstLine = Console.ReadLine();

            string[] firstLineParts = firstLine.Split(',');

            int rows = int.Parse(firstLineParts[0]);
            int cols = int.Parse(firstLineParts[1]);

            int[,] numbers = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();

                string[] lineParts = line.Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = int.Parse(lineParts[col]);
                }
            }

            for (int col = 0; col < numbers.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row < numbers.GetLength(0); row++)
                {
                    sum += numbers[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}


