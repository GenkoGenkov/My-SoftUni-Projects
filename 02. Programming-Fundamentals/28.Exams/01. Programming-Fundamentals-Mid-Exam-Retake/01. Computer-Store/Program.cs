using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTaaxes = 0;
            double taxes = 0;
            double totalPrice = 0;

            string command = Console.ReadLine();

            while (command != "special" && command != "regular")
            {
                double parts = double.Parse(command);

                if (parts < 0)
                {

                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }


                priceWithoutTaaxes = parts += priceWithoutTaaxes;


                command = Console.ReadLine();
            }

            taxes = priceWithoutTaaxes * 0.20;
            totalPrice = taxes + priceWithoutTaaxes;

            if (command == "special")
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }


            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWithoutTaaxes:F2}$");
            Console.WriteLine($"Taxes: {taxes:F2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:F2}$");
        }
    }
}