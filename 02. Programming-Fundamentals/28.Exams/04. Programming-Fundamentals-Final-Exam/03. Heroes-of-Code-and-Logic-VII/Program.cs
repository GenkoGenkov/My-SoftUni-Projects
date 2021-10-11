using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Heroes> allHeroes = new Dictionary<string, Heroes>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string name = input[0];
                int health = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                allHeroes.Add(name, new Heroes(health, mana));
            }

            string[] command = Console.ReadLine().Split(" - ");

            while (command[0] != "End")
            {
                if (command[0] == "CastSpell")
                {
                    string heroName = command[1];
                    int manaNeeded = int.Parse(command[2]);
                    string spellName = command[3];

                    if (manaNeeded <= allHeroes[heroName].Mana)
                    {
                        allHeroes[heroName].Mana -= manaNeeded;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {allHeroes[heroName].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command[0] == "TakeDamage")
                {
                    string heroName = command[1];
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    allHeroes[heroName].Health -= damage;

                    if (allHeroes[heroName].Health > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {allHeroes[heroName].Health} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");

                        allHeroes.Remove(heroName);
                    }
                }
                else if (command[0] == "Recharge")
                {
                    string heroName = command[1];
                    int ammount = int.Parse(command[2]);

                    if (allHeroes[heroName].Mana + ammount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - allHeroes[heroName].Mana} MP!");

                        allHeroes[heroName].Mana = 200;
                    }
                    else
                    {
                        allHeroes[heroName].Mana += ammount;

                        Console.WriteLine($"{heroName} recharged for {ammount} MP!");
                    }
                }
                else if (command[0] == "Heal")
                {
                    string heroName = command[1];
                    int ammount = int.Parse(command[2]);

                    if (allHeroes[heroName].Health + ammount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - allHeroes[heroName].Health} HP!");

                        allHeroes[heroName].Health = 100;
                    }
                    else
                    {
                        allHeroes[heroName].Health += ammount;

                        Console.WriteLine($"{heroName} healed for {ammount} HP!");
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }

            foreach (var hero in allHeroes.OrderByDescending(h => h.Value.Health).ThenBy(h => h.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.Health}");
                Console.WriteLine($"  MP: {hero.Value.Mana}");
            }
        }
    }

    class Heroes
    {
        public Heroes(int health, int mana)
        {
            Health = health;
            Mana = mana;
        }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
}
