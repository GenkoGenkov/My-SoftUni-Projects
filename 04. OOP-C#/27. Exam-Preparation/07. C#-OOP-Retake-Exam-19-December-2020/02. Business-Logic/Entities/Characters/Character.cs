using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.
        private string name;
        private double baseHealth;
        private double health;
        private double baseArmor;
        private double armor;




        public Character(string name, double health, double armor, double abilityPoints, Bag bag)

        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = health;
            this.BaseArmor = armor;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }


        public string Name
        {
            get => this.name;
            private set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                this.name = value;

            }
        }

        public double BaseHealth
        {
            get => this.baseHealth;
            private set
            {
                this.baseHealth = value;
            }
        }

        public double Health
        {
            get => this.health;
            set
            {
                if (value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                }
                else if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public bool IsAlive { get; set; } = true;

        public double BaseArmor
        {
            get => this.baseArmor;
            private set
            {
                this.baseArmor = value;
            }
        }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value >= 0)
                {
                    this.armor = value;
                }
                else this.armor = 0;
            }
        }

        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }


        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();

            if (hitPoints >= this.armor)
            {
                hitPoints -= this.armor;
                this.armor = 0;


            }
            else
            {
                this.armor -= hitPoints;
                hitPoints = 0;
            }

            if (hitPoints >= this.health)
            {
                IsAlive = false;

                health = 0;
            }

            else
            {
                this.Health -= hitPoints;
            }

        }

        public void UseItem(Item item)  //??
        {

            this.EnsureAlive();
            item.AffectCharacter(this);

        }


    }
}