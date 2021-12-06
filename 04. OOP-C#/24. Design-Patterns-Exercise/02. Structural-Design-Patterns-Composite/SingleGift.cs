using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name, decimal price) 
            : base(name, price)
        {
        }

        public override decimal CalculateTotalPrice() => Price;

    }
}
