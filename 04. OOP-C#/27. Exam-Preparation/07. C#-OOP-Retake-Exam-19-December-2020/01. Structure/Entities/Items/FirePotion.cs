using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int constWeight = 5;

        public FirePotion()
            : base(constWeight)
        {


        }

        public override void AffectCharacter(Character character)
        {
            // TODO decrease health - 20

            base.AffectCharacter(character);
            character.Health -= 20;
                        

        }
    }
}
