using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private const double baseHealth = 100;
        private const double baseArmor = 50;
        private const double abilityPoints = 40;
        private Satchel bag;
        public Warrior(string name)
            : base(name, baseHealth, baseArmor, abilityPoints, new Satchel())
        {


        }


        public void Attack(Character character)
        {
            this.EnsureAlive();
            if (!character.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }


                if (character.Name == this.Name)
            {
                throw new InvalidOperationException("Cannot attack self!");

            }

            character.TakeDamage(this.AbilityPoints);



        }
    }
}






