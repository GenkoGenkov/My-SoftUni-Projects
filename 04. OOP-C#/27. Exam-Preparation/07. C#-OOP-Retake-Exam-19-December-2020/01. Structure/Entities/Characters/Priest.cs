using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private const double baseHealth = 50;
        private const double baseArmor = 25;
        private const double abilityPoints = 40;
        private Bag bag;

       
        public Priest(string name)
            : base(name, baseHealth, baseArmor, abilityPoints, new Backpack())
        {

           

        }

        public void Heal(Character character)
        {
            if (IsAlive && character.IsAlive)
            {

                character.Health += abilityPoints;
                              
            }

            else
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }

        }
             

    }
}
