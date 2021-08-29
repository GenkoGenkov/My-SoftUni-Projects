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
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int volume = w * l * h;
            int boxesVolume = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int inputAsNumber = int.Parse(input);

                boxesVolume += inputAsNumber;

                if (volume < boxesVolume)
                {
                    Console.WriteLine($"No more free space! You need {boxesVolume - volume} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Done")
            {
                Console.WriteLine($"{volume - boxesVolume} Cubic meters left.");
            }
        }
    }
}
