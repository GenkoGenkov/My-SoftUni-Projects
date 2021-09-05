using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrise = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = (headsetPrice * (lostGamesCount / 2)) + (mousePrise * (lostGamesCount / 3)) + (keyboardPrice * (lostGamesCount / 6)) + (displayPrice * (lostGamesCount / 12));



            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}

