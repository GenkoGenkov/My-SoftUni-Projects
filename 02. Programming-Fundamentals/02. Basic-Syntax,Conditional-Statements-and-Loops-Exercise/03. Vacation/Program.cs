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
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerDay = 0;

            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerDay = 8.45;
                }
                else if (groupType == "Business")
                {
                    pricePerDay = 10.90;
                }
                else if (groupType == "Regular")
                {
                    pricePerDay = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerDay = 9.80;
                }
                else if (groupType == "Business")
                {
                    pricePerDay = 15.60;
                }
                else if (groupType == "Regular")
                {
                    pricePerDay = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerDay = 10.46;
                }
                else if (groupType == "Business")
                {
                    pricePerDay = 16;
                }
                else if (groupType == "Regular")
                {
                    pricePerDay = 22.50;
                }
            }

            double currentAmount = peopleCount * pricePerDay;

            if (groupType == "Students" && peopleCount >= 30)
            {
                currentAmount *= 0.85;
            }
            else if (groupType == "Business" && peopleCount >= 100)
            {
                currentAmount = (peopleCount - 10) * pricePerDay;
            }
            else if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                currentAmount *= 0.95;
            }

            Console.WriteLine($"Total price: {currentAmount:F2}");
        }
    }
}

