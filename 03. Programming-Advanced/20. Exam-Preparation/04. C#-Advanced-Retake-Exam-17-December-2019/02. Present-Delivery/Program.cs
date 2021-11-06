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
            int countOfPresents = int.Parse(Console.ReadLine());
            int neighbourhoodSize = int.Parse(Console.ReadLine());

            char[,] hood = new char[neighbourhoodSize, neighbourhoodSize];

            int santaRow = -1;
            int santaCol = -1;
            int niceKidsPresents = 0;

            for (int i = 0; i < neighbourhoodSize; i++)
            {
                var line = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < line. Length; j++)
                {
                    hood[i, j] = line[j];

                    if (hood[i, j] == 'S')
                    {
                        santaRow = i;
                        santaCol = j;
                    }

                    if (hood[i, j] == 'V')
                    {
                        niceKidsPresents++;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "Christmas morning")
            {

                if (countOfPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }

                hood[santaRow, santaCol] = '-';

                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;

                    case "down":
                        santaRow++;
                        break;

                    case "left":
                        santaCol--;
                        break;

                    case "right":
                        santaCol++;
                        break;

                    default:
                        break;
                }

                if (hood[santaRow, santaCol] == 'V')
                {                  
                    countOfPresents--;
                }
                else if (hood[santaRow, santaCol] == 'C')
                {
                    if (hood[santaRow - 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow - 1, santaCol] = '-';
                    }

                    if (hood[santaRow + 1, santaCol] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow + 1, santaCol] = '-';
                    }

                    if (hood[santaRow, santaCol + 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol + 1] = '-';
                    }

                    if (hood[santaRow, santaCol - 1] != '-')
                    {
                        countOfPresents--;
                        hood[santaRow, santaCol - 1] = '-';
                    }
                }

                command = Console.ReadLine();
            }

            hood[santaRow, santaCol] = 'S';

            int niceKidsWithNoPresent = 0;

            for (int row = 0; row < neighbourhoodSize; row++)
            {
                for (int col = 0; col < neighbourhoodSize; col++)
                {
                    Console.Write(hood[row, col] + " ");

                    if (hood[row, col] == 'V')
                    {
                        niceKidsWithNoPresent++;
                    }
                }
                Console.WriteLine();
            }

            if (niceKidsWithNoPresent == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsPresents} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsWithNoPresent} nice kid/s.");
            }
        }
    }
}

