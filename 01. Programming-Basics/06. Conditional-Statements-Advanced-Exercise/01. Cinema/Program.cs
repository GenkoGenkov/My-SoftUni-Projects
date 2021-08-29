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
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int seats = rows * colums;
            double price = 0;

            switch (type)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.50; break;
                case "Discount": price = 5; break;

            }

            double total = price * seats;

            Console.WriteLine($"{total:F2} leva,income");
        }
    }
}
