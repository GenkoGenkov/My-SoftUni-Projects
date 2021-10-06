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
            StringBuilder countries = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] information = command.Split(":");

                string action = information[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(information[1]);
                    string destination = information[2];

                    if (index <= countries.Length - 1 && index >= 0)
                    {
                        countries.Insert(index, destination);
                    }

                    Console.WriteLine(string.Join("", countries));
                }
                else if (action == "Remove Stop")
                {
                    int start = int.Parse(information[1]);
                    int end = int.Parse(information[2]);

                    if (start >= 0 && start <= countries.Length - 1 && end <= countries.Length - 1 && end >= 0)
                    {
                        countries.Remove(start, end - start + 1);
                    }

                    Console.WriteLine(string.Join("", countries));
                }
                else if (action == "Switch")
                {
                    string old = information[1];
                    string @new = information[2];

                    if (countries.ToString().Contains(old) && old != @new)
                    {
                        countries.Replace(old, @new);
                    }

                    Console.WriteLine(string.Join("", countries));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {string.Join("", countries)}");
        }
    }
}

