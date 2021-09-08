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
            int yeld = int.Parse(Console.ReadLine());

            int totalAmmount = 0;
            int days = 0;

            while (yeld >= 100)
            {
                totalAmmount += yeld - 26;
                days++;
                yeld -= 10;
            }

            if (days > 0)
            {
                totalAmmount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmmount);
        }
    }
}

