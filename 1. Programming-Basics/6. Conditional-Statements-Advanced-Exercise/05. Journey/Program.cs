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
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var destination = "";
            var placeToStay = "";
            var price = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    placeToStay = "Camp";
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    placeToStay = "Hotel";
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                placeToStay = "Hotel";
                price = budget * 0.9;
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {price:F2}");
        }
    }
}
