using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Food
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get ; set ; }
    }
}
