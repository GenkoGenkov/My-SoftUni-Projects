using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();

            Stack<int> numbers = new Stack<int>();

            string[] numbersList = numbersAsString.Split(' ');

            foreach (var item in numbersList)
            {
                numbers.Push(int.Parse(item));
            }

            while (true)
            {
                string line = Console.ReadLine();

                string[] data = line.Split(' ');

                string command = data[0].ToLower();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    numbers.Push(int.Parse(data[1]));
                    numbers.Push(int.Parse(data[2]));
                }
                else if (command == "remove")
                {
                    int removed = int.Parse(data[1]);

                    if (removed <= numbers.Count)
                    {
                        for (int i = 0; i < removed; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
