using System;
using System.Collections.Generic;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int officerRow = 0;
            int officerCol = 0;
            int gold = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];

                    if (matrix[rows, cols] == 'A')
                    {
                        officerRow = rows;
                        officerCol = cols;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                matrix[officerRow, officerCol] = '-';

                if (command == "up")
                {
                    officerRow--;

                    if (officerRow >= 0)
                    {
                        if (char.IsDigit(matrix[officerRow, officerCol]))
                        {
                            gold += int.Parse(matrix[officerRow, officerCol].ToString());
                        }
                        else if (matrix[officerRow, officerCol] == 'M')
                        {
                            matrix[officerRow, officerCol] = '_';
                            for (int rows = 0; rows < n; rows++)
                            {
                                for (int cols = 0; cols < n; cols++)
                                {
                                    if (matrix[rows, cols] == 'M')
                                    {
                                        officerRow = rows;
                                        officerCol = cols;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                }
                else if (command == "down")
                {
                    officerRow++;

                    if (officerRow < n)
                    {
                        if (char.IsDigit(matrix[officerRow, officerCol]))
                        {
                            gold += int.Parse(matrix[officerRow, officerCol].ToString());
                        }
                        else if (matrix[officerRow, officerCol] == 'M')
                        {
                            matrix[officerRow, officerCol] = '-';
                            for (int rows = 0; rows < n; rows++)
                            {
                                for (int cols = 0; cols < n; cols++)
                                {
                                    if (matrix[rows, cols] == 'M')
                                    {
                                        officerRow = rows;
                                        officerCol = cols;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                }
                else if (command == "left")
                {
                    officerCol--;

                    if (officerCol >= 0)
                    {
                        if (char.IsDigit(matrix[officerRow, officerCol]))
                        {
                            gold += int.Parse(matrix[officerRow, officerCol].ToString());
                        }
                        else if (matrix[officerRow, officerCol] == 'M')
                        {
                            matrix[officerRow, officerCol] = '-';
                            for (int rows = 0; rows < n; rows++)
                            {
                                for (int cols = 0; cols < n; cols++)
                                {
                                    if (matrix[rows, cols] == 'M')
                                    {
                                        officerRow = rows;
                                        officerCol = cols;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                }
                else if (command == "right")
                {
                    officerCol++;

                    if (officerCol < n)
                    {
                        if (char.IsDigit(matrix[officerRow, officerCol]))
                        {
                            gold += int.Parse(matrix[officerRow, officerCol].ToString());
                        }
                        else if (matrix[officerRow, officerCol] == 'M')
                        {
                            matrix[officerRow, officerCol] = '-';
                            for (int rows = 0; rows < n; rows++)
                            {
                                for (int cols = 0; cols < n; cols++)
                                {
                                    if (matrix[rows, cols] == 'M')
                                    {
                                        officerRow = rows;
                                        officerCol = cols;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I do not need more swords!");
                        break;
                    }
                }

                if (gold >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    matrix[officerRow, officerCol] = 'A';
                    break;
                }

                matrix[officerRow, officerCol] = 'A';
            }

            Console.WriteLine($"The king paid {gold} gold coins.");

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write($"{matrix[rows, cols]}");
                }

                Console.WriteLine();
            }
        }
    }
}
