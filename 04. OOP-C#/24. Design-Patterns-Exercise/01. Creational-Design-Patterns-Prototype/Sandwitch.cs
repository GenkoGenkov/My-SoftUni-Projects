using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Sandwitch : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwitch(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype DeeoCopy()
        {
            string newBread = new string(bread);
            string newMeat = new string(meat);
            string newCheese = new string(cheese);
            string newVeggies = new string(veggies);

            Sandwitch sandwitch = new Sandwitch(newBread, newMeat, newCheese, newVeggies);

            return sandwitch;
        }

        public string GetIngridients() => $"{bread}, {meat}, {cheese}, {veggies}";

        public override SandwichPrototype ShallowCopy()
        {
            Console.WriteLine($"Cloning sandwitch with ingridients : {GetIngridients()}");

            return MemberwiseClone() as SandwichPrototype;
        }
    }
}
