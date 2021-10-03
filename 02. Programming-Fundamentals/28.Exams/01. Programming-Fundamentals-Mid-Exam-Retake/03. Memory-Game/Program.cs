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
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            int moves = 0;

            while (input != "end")
            {
                string[] indeces = input.Split();
                int indexOne = int.Parse(indeces[0]);
                int indexTwo = int.Parse(indeces[1]);
                moves++;

                if (indexTwo < 0 || indexTwo >= elements.Count || indexOne < 0 || indexOne >= elements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                    int addIndex = elements.Count / 2;
                    elements.Insert(addIndex, $"-{moves}a");
                    elements.Insert(addIndex, $"-{moves}a");
                }
                else if (elements[indexOne] == elements[indexTwo])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[indexOne]}!");

                    string itemDelete = elements[indexOne];
                    elements.RemoveAll(e => e == itemDelete);
                }
                else if (elements[indexOne] != elements[indexTwo])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}