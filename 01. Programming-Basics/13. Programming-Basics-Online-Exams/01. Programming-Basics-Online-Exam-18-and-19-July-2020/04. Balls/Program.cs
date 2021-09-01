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
            int n = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int otherColours = 0;

            for (int i = 0; i < n; i++)
            {
                string colours = Console.ReadLine();

                if (colours == "red")
                {
                    totalPoints += 5;
                    red++;
                }
                else if (colours == "orange")
                {
                    totalPoints += 10;
                    orange++;
                }
                else if (colours == "yellow")
                {
                    totalPoints += 15;
                    yellow++;
                }
                else if (colours == "white")
                {
                    totalPoints += 20;
                    white++;
                }
                else if (colours == "black")
                {
                    totalPoints = totalPoints / 2;
                    black++;
                }
                else
                {
                    otherColours++;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");
            Console.WriteLine($"Points from yellow balls: {yellow}");
            Console.WriteLine($"Points from white balls: {white}");
            Console.WriteLine($"Other colors picked: {otherColours}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}

