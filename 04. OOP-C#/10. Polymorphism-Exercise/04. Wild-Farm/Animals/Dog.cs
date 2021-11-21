using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.40;
            }
            else
            {
                ThrowException(this, food);
            }
        }

        public override string ProduseSound() => "Woof!";

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
