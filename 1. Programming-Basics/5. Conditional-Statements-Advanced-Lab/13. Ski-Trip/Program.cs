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
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double sumForAllNights = 0;

            if (roomType == "room for one person")
            {
                sumForAllNights = nights * 18;

            }
            else if (roomType == "apartment")
            {
                if (days < 10)
                {
                    sumForAllNights = (nights * 25) * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumForAllNights = (nights * 25) * 0.65;
                }
                else if (days > 15)
                {
                    sumForAllNights = (nights * 25) * 0.5;
                }


            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    sumForAllNights = (nights * 35) * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    sumForAllNights = (nights * 35) * 0.85;
                }
                else if (days > 15)
                {
                    sumForAllNights = (nights * 35) * 0.8;
                }


            }

            if (feedback == "positive")
            {
                sumForAllNights = sumForAllNights * 1.25;
            }
            else if (feedback == "negative")
            {
                sumForAllNights = sumForAllNights * 0.9;
            }

            Console.WriteLine($"{sumForAllNights:F2}");
        }
    }
}
