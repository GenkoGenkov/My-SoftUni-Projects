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
            string movieTitle = Console.ReadLine();
            string roomType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double finalSum = 0;

            if (movieTitle == "A Star Is Born")
            {
                if (roomType == "normal")
                {
                    finalSum = tickets * 7.50;
                }
                else if (roomType == "luxury")
                {
                    finalSum = tickets * 10.50;
                }
                else if (roomType == "ultra luxury")
                {
                    finalSum = tickets * 13.50;
                }
            }
            else if (movieTitle == "Bohemian Rhapsody")
            {
                if (roomType == "normal")
                {
                    finalSum = tickets * 7.35;
                }
                else if (roomType == "luxury")
                {
                    finalSum = tickets * 9.45;
                }
                else if (roomType == "ultra luxury")
                {
                    finalSum = tickets * 12.75;
                }
            }
            else if (movieTitle == "Green Book")
            {
                if (roomType == "normal")
                {
                    finalSum = tickets * 8.15;
                }
                else if (roomType == "luxury")
                {
                    finalSum = tickets * 10.25;
                }
                else if (roomType == "ultra luxury")
                {
                    finalSum = tickets * 13.25;
                }
            }
            else if (movieTitle == "The Favourite")
            {
                if (roomType == "normal")
                {
                    finalSum = tickets * 8.75;
                }
                else if (roomType == "luxury")
                {
                    finalSum = tickets * 11.55;
                }
                else if (roomType == "ultra luxury")
                {
                    finalSum = tickets * 13.95;
                }
            }

            Console.WriteLine($"{movieTitle} -> {finalSum:F2} lv.");
        }
    }
}

