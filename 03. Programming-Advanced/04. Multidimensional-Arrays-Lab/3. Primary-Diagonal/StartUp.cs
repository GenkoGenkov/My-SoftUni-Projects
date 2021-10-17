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

            int[,] matrix = new int[n, n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];

                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}


