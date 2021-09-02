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
            int numberOfGroups = int.Parse(Console.ReadLine());

            double moussala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double kTwo = 0;
            double everest = 0;
            double allPeople = 0;


            for (int i = 1; i <= numberOfGroups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    moussala = people + moussala;
                    allPeople += people;
                }
                else if (people > 5 && people <= 12)
                {
                    monblan = people + monblan;
                    allPeople += people;
                }
                else if (people > 12 && people <= 25)
                {
                    kilimandjaro = people + kilimandjaro;
                    allPeople += people;
                }
                else if (people > 25 && people <= 40)
                {
                    kTwo = people + kTwo;
                    allPeople += people;
                }
                else if (people > 40)
                {
                    everest = people + everest;
                    allPeople += people;
                }
            }

            Console.WriteLine($"{moussala / allPeople * 100:F2}%");
            Console.WriteLine($"{monblan / allPeople * 100:F2}%");
            Console.WriteLine($"{kilimandjaro / allPeople * 100:F2}%");
            Console.WriteLine($"{kTwo / allPeople * 100:F2}%");
            Console.WriteLine($"{everest / allPeople * 100:F2}%");
        }
    }
}

