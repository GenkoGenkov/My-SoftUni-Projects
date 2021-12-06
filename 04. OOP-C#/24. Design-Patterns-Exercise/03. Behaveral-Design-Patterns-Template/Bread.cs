using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Bread
    {
        public abstract void Bake();

        public abstract void MixIngridients();

        public virtual void Slice()
        {
            Console.WriteLine($"Slicing the {this.GetType().Name} bread!");
        }

        public void Make()
        {
            MixIngridients();
            Bake();
            Slice();
        }
    }
}
