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
            List<int> movingTarget = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split(" ");

                string action = data[0];

                if (action == "Shoot")
                {
                    int index = int.Parse(data[1]);
                    int power = int.Parse(data[2]);

                    if (index >= 0 && index < movingTarget.Count)
                    {
                        movingTarget[index] -= power;

                        if (movingTarget[index] <= 0)
                        {
                            movingTarget.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Strike")
                {
                    int index = int.Parse(data[1]);
                    int radius = int.Parse(data[2]);

                    int start = index - radius;
                    int end = index + radius;

                    if (start >= 0 && end < movingTarget.Count)
                    {
                        movingTarget.RemoveRange(start, end - start + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                else if (action == "Add")
                {
                    int index = int.Parse(data[1]);
                    int value = int.Parse(data[2]);

                    if (index >= 0 && index < movingTarget.Count)
                    {
                        movingTarget.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", movingTarget));
        }
    }
}

