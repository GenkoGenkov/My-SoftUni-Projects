using ConsoleApp1.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            FoodEaten += food.Quantity;
            Weight += food.Quantity * 0.35;
        }

        public override string ProduseSound() => "Cluck";
    }
}
