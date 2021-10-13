using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Town> piracy = new Dictionary<string, Town>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] data = input.Split("||");

                string town = data[0];
                int population = int.Parse(data[1]);
                int gold = int.Parse(data[2]);

                if (!piracy.ContainsKey(town))
                {
                    piracy.Add(town, new Town(population, gold));
                }
                else
                {
                    piracy[town].Population += population;
                    piracy[town].Gold += gold;
                }

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] data = commands.Split("=>");

                string action = data[0];

                if (action == "Plunder")
                {
                    string town = data[1];
                    int people = int.Parse(data[2]);
                    int gold = int.Parse(data[3]);

                    piracy[town].Population -= people;
                    piracy[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (piracy[town].Population == 0 || piracy[town].Gold == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");

                        piracy.Remove(town);

                    }
                }
                else if (action == "Prosper")
                {
                    string town = data[1];
                    int gold = int.Parse(data[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        piracy[town].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {piracy[town].Gold} gold.");
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"Ahoy, Captain! There are {piracy.Count} wealthy settlements to go to:");

            foreach (var item in piracy.OrderByDescending(i => i.Value.Gold).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
            }
        }
    }

    class Town
    {
        public Town(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}