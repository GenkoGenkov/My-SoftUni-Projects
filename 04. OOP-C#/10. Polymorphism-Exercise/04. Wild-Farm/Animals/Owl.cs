using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                FoodEaten += food.Quantity;
                Weight += food.Quantity * 0.25;
            }
            else
            {
                ThrowException(this, food);
            }
        }

        public override string ProduseSound() => "Hoot Hoot";
    }
}
