using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dwarfes = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {
                string[] data = command.Split(" <:> ");

                string name = data[0];
                string hat = data[1];
                int physics = int.Parse(data[2]);

                if (!dwarfes.ContainsKey(hat))
                {
                    dwarfes.Add(hat, new Dictionary<string, int>());
                    dwarfes[hat].Add(name, physics);
                }
                else
                {
                    if (!dwarfes[hat].ContainsKey(name))
                    {
                        dwarfes[hat].Add(name, physics);
                    }
                    else
                    {
                        if (dwarfes[hat][name] < physics)
                        {
                            dwarfes[hat][name] = physics;
                        }
                    }
                }


                command = Console.ReadLine();
            }

            Dictionary<string, int> dwData = new Dictionary<string, int>();

            foreach (var dwarf in dwarfes.OrderByDescending(d => d.Value.Count))
            {
                foreach (var data in dwarf.Value)
                {
                    dwData.Add($"({dwarf.Key}) {data.Key} <-> ", data.Value);
                }
            }

            foreach (var dwarf in dwData.OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}