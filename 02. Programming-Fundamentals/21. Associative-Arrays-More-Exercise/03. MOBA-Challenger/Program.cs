using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] data = command.Split(" -> ");

                    string player = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        if (players[player].ContainsKey(position))
                        {
                            if (players[player][position] < skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                        else
                        {
                            players[player].Add(position, skill);
                        }
                    }
                }
                else if (command.Contains("vs"))
                {
                    string[] data = command.Split(" vs ");

                    string firstPlayer = data[0];
                    string secondPlayer = data[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        if (players[firstPlayer].Keys.Intersect(players[secondPlayer].Keys).Any())
                        {
                            if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (players[firstPlayer].Values.Sum() < players[secondPlayer].Values.Sum())
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }


                command = Console.ReadLine();
            }

            foreach (var users in players.OrderByDescending(u => u.Value.Values.Sum()).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{users.Key}: {users.Value.Values.Sum()} skill");

                foreach (var role in users.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"- {role.Key} <::> {role.Value}");
                }
            }
        }
    }
}