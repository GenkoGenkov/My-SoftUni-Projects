using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] data = command.Split(" | ");

                    string side = data[0];
                    string user = data[1];

                    if (!register.ContainsKey(side))
                    {
                        register.Add(side, new List<string>());
                    }

                    if (!register[side].Contains(user) && !register.Values.Any(s => s.Contains(user)))
                    {
                        register[side].Add(user);
                    }
                }
                else if (command.Contains("->"))
                {
                    string[] data = command.Split(" -> ");

                    string side = data[1];
                    string user = data[0];

                    if (!register.Values.Any(u => u.Contains(user)))
                    {
                        if (!register.ContainsKey(side))
                        {
                            register.Add(side, new List<string>());
                        }

                        register[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var item in register)
                        {
                            if (item.Value.Contains(user))
                            {
                                item.Value.Remove(user);
                            }
                        }

                        if (!register.ContainsKey(side))
                        {
                            register.Add(side, new List<string>());
                        }

                        register[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }


                command = Console.ReadLine();
            }

            register = register.OrderByDescending(u => u.Value.Count).ThenBy(u => u.Key).ToDictionary(u => u.Key, u => u.Value);

            foreach (var users in register)
            {
                users.Value.Sort();

                if (users.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {users.Key}, Members: {users.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join($"\n! ", users.Value));
                }
            }
        }
    }
}