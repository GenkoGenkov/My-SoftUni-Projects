using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class CompositeGifts : GiftBase, IGiftOperations
    {
        private readonly HashSet<GiftBase> giftBases;

        public CompositeGifts(string name, decimal price) 
            : base(name, price)
        {
            giftBases = new HashSet<GiftBase>();
        }

        public void Add(GiftBase gift) => giftBases.Add(gift);

        public void Remove(GiftBase gift) => giftBases.Remove(gift);

        public override decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in giftBases)
            {
                totalPrice += item.CalculateTotalPrice();
            }

            return totalPrice;
        }
    }
}
