using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Generate")
            {
                string[] info = commands.Split(">>>");

                string action = info[0];

                if (action == "Slice")
                {
                    int start = int.Parse(info[1]);
                    int end = int.Parse(info[2]);

                    key = key.Remove(start, end - start);

                    Console.WriteLine(key);
                }
                else if (action == "Flip")
                {
                    string upperLower = info[1];
                    int start = int.Parse(info[2]);
                    int end = int.Parse(info[3]);

                    if (upperLower == "Upper")
                    {
                        for (int i = start; i < end; i++)
                        {
                            char current = char.ToUpper(key[i]);

                            key = key.Remove(i, 1);
                            key = key.Insert(i, current.ToString());
                        }
                    }
                    else if (upperLower == "Lower")
                    {
                        for (int i = start; i < end; i++)
                        {
                            char current = char.ToLower(key[i]);

                            key = key.Remove(i, 1);
                            key = key.Insert(i, current.ToString());
                        }
                    }

                    Console.WriteLine(key);

                }
                else if (action == "Contains")
                {
                    string substring = info[1];

                    if (key.Contains(substring))
                    {
                        Console.WriteLine($"{key} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
