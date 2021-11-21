using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public virtual string CastAbility()
            => $"{GetType().Name} - {Name} ";
    }
}
