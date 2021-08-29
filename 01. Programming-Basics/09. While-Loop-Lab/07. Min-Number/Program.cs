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
            string input = Console.ReadLine();

            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int currentNUmber = int.Parse(input);

                if (currentNUmber < minNumber)
                {
                    minNumber = currentNUmber;
                }

                input = Console.ReadLine();

            }

            if (input == "Stop")
            {
                Console.WriteLine(minNumber);
            }
        }
    }
}
