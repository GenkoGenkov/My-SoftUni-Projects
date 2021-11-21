using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.30;
            }
            else
            {
                ThrowException(this, food);
            }
        }

        public override string ProduseSound() => "Meow";
    }
}
