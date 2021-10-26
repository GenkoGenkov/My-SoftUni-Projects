using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                string[] inputInfo = input.Split();

                string trainername = inputInfo[0];
                string pokemonName = inputInfo[1];
                string element = inputInfo[2];
                int health = int.Parse(inputInfo[3]);

                if (!trainers.ContainsKey(trainername))
                {
                    Trainer newTrainers = new Trainer(trainername);

                    trainers.Add(trainername, newTrainers);
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                Trainer trainer = trainers[trainername];
                trainer.Pokemons.Add(pokemon);


                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Value.Badges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

               input = Console.ReadLine();
            }

            foreach (var item in trainers.OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
