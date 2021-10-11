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
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] data = command.Split(" ");

                string action = data[0];

                if (action == "TakeOdd")
                {
                    string odd = string.Empty;

                    for (int i = 1; i < input.Length; i += 2)
                    {
                        odd += input[i];
                    }

                    input = odd;

                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(data[1]);
                    int lenght = int.Parse(data[2]);

                    input = input.Remove(index, lenght);

                    Console.WriteLine(input);
                }
                else if (action == "Substitute")
                {
                    string old = data[1];
                    string @new = data[2];

                    if (!input.Contains(old))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        input = input.Replace(old, @new);
                        Console.WriteLine(input);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}

