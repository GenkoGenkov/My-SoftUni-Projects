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
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] data = command.Split();

                string action = data[0];
                string item = data[1];

                if (action == "Urgent")
                {
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (action == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                }
                else if (action == "Correct")
                {
                    if (shoppingList.Contains(data[1]))
                    {
                        int index = shoppingList.FindIndex(s => s == data[1]);
                        shoppingList.RemoveAt(index);
                        shoppingList.Insert(index, data[2]);
                    }
                }
                else if (action == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        int index = shoppingList.FindIndex(s => s == item);
                        shoppingList.RemoveAt(index);
                        shoppingList.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}

