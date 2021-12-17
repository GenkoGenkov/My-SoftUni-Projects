using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> party;
        private Stack<Item> pool;

        public WarController()
        {
            party = new List<Character>();
            pool = new Stack<Item>();
        }

        public string JoinParty(string[] args)       //1   OK ?
        {
            string type = args[0];
            string name = args[1];

            if (type != nameof(Warrior) && type != nameof(Priest))
            {
                throw new ArgumentException($"Invalid character type \"{type}\"!");

            }
            Character character = null;
            if (type == nameof(Warrior))
            {
                character = new Warrior(name);
            }
            else
            {
                character = new Priest(name);
            }

            party.Add(character);
            return $"{name} joined the party!";

        }

        public string AddItemToPool(string[] args) //2    OK?
        {
            string itemName = args[0];

            if (itemName != nameof(FirePotion) && itemName != nameof(HealthPotion))
            {
                throw new ArgumentException($"Invalid item \"{itemName}\"!");

            }

            Item item = null;
            if (itemName == nameof(FirePotion))
            {
                item = new FirePotion();
            }
            else
            {
                item = new HealthPotion();
            }

            this.pool.Push(item);
            return $"{itemName} added to pool.";


        }

        public string PickUpItem(string[] args)  //3  OK ?
        {
            string characterName = args[0];

            Character character = party.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            if (pool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
            Item item = this.pool.Pop();
            character.Bag.AddItem(item);
            return $"{characterName} picked up {item.GetType().Name}!";


        }

        public string UseItem(string[] args)  //4    OK?
        {
            string characterName = args[0];
            string itemName = args[1];

            Character character = party.FirstOrDefault(x => x.Name == characterName);

            if (character == null)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }

            Item item = character.Bag.GetItem(itemName);
            character.UseItem(item);

            return $"{character.Name} used {itemName}.";
        }

        public string GetStats()  //5    OK?
        {
            // "{name} - HP: {health}/{baseHealth}, AP: {armor}/{baseArmor},
            // Status: {Alive/Dead}"

            List<Character> sortedParty = party.OrderByDescending(x => x.IsAlive==true).ThenByDescending(x => x.Health).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var hero in sortedParty)
            {
                string status;

                if (hero.IsAlive)
                {
                    status = "Alive";
                }
                else
                {
                    status = "Dead";
                }

                sb.AppendLine($"{hero.Name} - HP: {hero.Health}/{hero.BaseHealth}, AP: {hero.Armor}/{hero.BaseArmor},  Status: {status}");
             

            }
            return sb.ToString().Trim();

        }

        public string Attack(string[] args) //6   OK???
        {
            string attackerName = args[0];
            string receiverName = args[1];

            if (!party.Any(x => x.Name == attackerName))
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }
            if (!party.Any(x => x.Name == receiverName))
            {
                throw new ArgumentException($"Character {receiverName} not found!");
            }
            Character attacker = party.FirstOrDefault(x => x.Name == attackerName);
            Character receiver = party.FirstOrDefault(x => x.Name == receiverName);

            if (attacker.GetType().Name == nameof(Priest))
            {
                throw new ArgumentException($"{attackerName} cannot attack!");

            }
            Warrior warrior = (Warrior)attacker;

            warrior.Attack(receiver);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has " +
                $"{receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (!receiver.IsAlive)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }
            return sb.ToString().Trim();

        }

        public string Heal(string[] args) //7
        {
            string healerName = args[0];
            string healingReceiverName = args[1];

            if (!party.Any(x => x.Name == healerName))
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }
            if (!party.Any(x => x.Name == healingReceiverName))
            {
                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }


            Character healer = party.FirstOrDefault(x => x.Name == healerName);
            Character receiver = party.FirstOrDefault(x => x.Name == healingReceiverName);

            if (healer.GetType().Name == nameof(Warrior))
            {
                throw new ArgumentException($"{healerName} cannot heal!");

            }

            Priest priest = (Priest)healer;
            priest.Heal(receiver);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!");

            return sb.ToString().Trim();
        }
    }
}