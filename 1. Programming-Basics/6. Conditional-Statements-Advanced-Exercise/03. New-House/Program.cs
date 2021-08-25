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
            string flower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            double add = 0;

            switch (flower)
            {
                case "Roses":
                    price = 5;

                    if (numOfFlowers > 80)
                    {
                        discount = 0.10;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;

                    if (numOfFlowers > 90)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Tulips":
                    price = 2.80;

                    if (numOfFlowers > 80)
                    {
                        discount = 0.15;
                    }
                    break;
                case "Narcissus":
                    price = 3;

                    if (numOfFlowers < 120)
                    {
                        add = 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;

                    if (numOfFlowers < 80)
                    {
                        add = 0.20;
                    }
                    break;
                default:
                    break;
            }

            double total = numOfFlowers * price;

            total = total - total * discount;
            total = total + total * add;

            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flower} and {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }
        }
    }
}
