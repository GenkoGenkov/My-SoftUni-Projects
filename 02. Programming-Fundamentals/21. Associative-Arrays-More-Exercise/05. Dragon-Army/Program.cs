using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Dragon>> dragonTypes = new Dictionary<string, List<Dragon>>();

            for (int j = 0; j < n; j++)
            {
                string[] data = Console.ReadLine().Split();

                string type = data[0];
                string name = data[1];
                int damage = data[2] == "null" ? 45 : int.Parse(data[2]);
                int health = data[3] == "null" ? 250 : int.Parse(data[3]);
                int armor = data[4] == "null" ? 10 : int.Parse(data[4]);

                Dragon currentDragon = new Dragon(name, damage, health, armor);

                if (!dragonTypes.ContainsKey(type))
                {
                    dragonTypes.Add(type, new List<Dragon>());
                    dragonTypes[type].Add(currentDragon);
                }
                else
                {

                    if (dragonTypes[type].Any(d => d.Name == name))
                    {
                        int dragonIndex = dragonTypes[type].FindIndex(i => i.Name == name);

                        dragonTypes[type][dragonIndex] = currentDragon;
                    }
                    else
                    {
                        dragonTypes[type].Add(currentDragon);
                    }
                }
            }

            foreach (var type in dragonTypes)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(d => d.Damage):f2}/{type.Value.Average(d => d.Health):f2}/{type.Value.Average(d => d.Armor):f2})");

                foreach (var dragon in type.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine(dragon);
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public override string ToString()
        {
            return $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
        }
    }
}