using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Fruit)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.10;
            }
            else
            {
                ThrowException(this, food);
            }
        }

        public override string ProduseSound() => "Squeak";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
