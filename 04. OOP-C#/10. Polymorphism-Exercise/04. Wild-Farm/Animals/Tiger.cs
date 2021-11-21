using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 1.00;
            }
            else
            {
                ThrowException(this, food);
            }
        }

        public override string ProduseSound() => "ROAR!!!";
    }
}
