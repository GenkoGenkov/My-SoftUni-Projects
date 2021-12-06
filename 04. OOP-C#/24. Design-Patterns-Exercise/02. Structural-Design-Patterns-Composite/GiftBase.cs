using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class GiftBase
    {
        private string name;
        private decimal price;

        protected GiftBase(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }

        public abstract decimal CalculateTotalPrice();
    }
}
