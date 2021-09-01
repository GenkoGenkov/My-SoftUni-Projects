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
            string company = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double priceForAdults = double.Parse(Console.ReadLine());
            double serviseTax = double.Parse(Console.ReadLine());

            double priceForKids = priceForAdults * 0.3;
            double adultPriceWithTax = priceForAdults + serviseTax;
            double kidsPriceWithTax = priceForKids + serviseTax;
            double allTickets = (adultPriceWithTax * adultTickets) + (kidsPriceWithTax * kidTickets);
            double final = allTickets * 0.2;

            Console.WriteLine($"The profit of your agency from {company} tickets is {final:F2} lv.");
        }
    }
}

