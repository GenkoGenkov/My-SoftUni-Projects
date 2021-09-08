using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());

            BigInteger biggestValue = 0;
            int biggestSnow = 0;
            int biggestTime = 0;
            int biggestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger currentValue = BigInteger.Pow(snow / time, quality);

                if (currentValue > biggestValue)
                {
                    biggestValue = currentValue;
                    biggestSnow = snow;
                    biggestTime = time;
                    biggestQuality = quality;
                }
            }

            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }
    }
}

