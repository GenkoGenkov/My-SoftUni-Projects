using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GiftBase tarzan = new SingleGift("Tarzan", 12.50m);
            decimal totalPrice = tarzan.CalculateTotalPrice();
            Console.WriteLine(totalPrice);

            CompositeGifts compositeGifts = new CompositeGifts("Root", 0);
            GiftBase pikachu = new SingleGift("Pikachu", 13.50m);

            compositeGifts.Add(tarzan);
            compositeGifts.Add(pikachu);

            CompositeGifts smallBox = new CompositeGifts("SmallBox", 0);
            GiftBase dragon = new SingleGift("Dragon", 10m);

            smallBox.Add(dragon);
            compositeGifts.Add(smallBox);

            decimal finalPrice = compositeGifts.CalculateTotalPrice();

            Console.WriteLine(finalPrice);
        }
    }
}
