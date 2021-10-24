using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] info = command.Split();

                Predicate<string> predicate = GetPredicate(info[1], info[2]);

                if (info[0] == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (info[0] == "Double")
                {
                    List<string> doubledNames = names.FindAll(predicate);

                    if (doubledNames.Any())
                    {
                        int index = names.FindIndex(predicate);

                        names.InsertRange(index, doubledNames);
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string info, string param)
        {
            if (info == "StartsWith")
            {
                return x => x.StartsWith(param);
            }

            if (info == "EndsWith")
            {
                return x => x.EndsWith(param);
            }

            int lenght = int.Parse(param);

            return x => x.Length == lenght;
        }
    }
}