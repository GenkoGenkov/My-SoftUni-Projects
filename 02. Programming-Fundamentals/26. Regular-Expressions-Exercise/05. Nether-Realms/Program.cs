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
            string patternNameHealth = @"[^\d\+\-*\/\.]";
            string patternDamage = @"(?:\+|-)?[0-9]+(?:\.[0-9]+)?";
            string patternOperators = @"[*\/]";

            string[] demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> demonHP = new Dictionary<string, int>();
            Dictionary<string, double> demonDMG = new Dictionary<string, double>();

            for (int i = 0; i < demons.Length; i++)
            {
                string name = demons[i];

                MatchCollection demonHealthMatch = Regex.Matches(name, patternNameHealth);
                MatchCollection demonDamageMatch = Regex.Matches(name, patternDamage);
                MatchCollection operatorsMatch = Regex.Matches(name, patternOperators);

                double damage = 0;
                int health = 0;

                if (Regex.IsMatch(name, patternNameHealth))
                {
                    foreach (Match item in demonHealthMatch)
                    {
                        health += char.Parse(item.ToString());
                    }

                    demonHP.Add(name, health);
                }

                if (Regex.IsMatch(name, patternDamage))
                {
                    foreach (Match item in demonDamageMatch)
                    {
                        damage += double.Parse(item.ToString());
                    }
                }

                if (Regex.IsMatch(name, patternOperators))
                {
                    foreach (Match item in operatorsMatch)
                    {
                        if (item.ToString() == "*")
                        {
                            damage *= 2;
                        }
                        else if (item.ToString() == "/")
                        {
                            damage /= 2;
                        }
                    }
                }

                demonDMG.Add(name, damage);

            }

            foreach (var (key, value) in demonHP.OrderBy(d => d.Key))
            {
                string name = key;
                int health = value;
                double damage = demonDMG[name];

                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }
        }
    }
}