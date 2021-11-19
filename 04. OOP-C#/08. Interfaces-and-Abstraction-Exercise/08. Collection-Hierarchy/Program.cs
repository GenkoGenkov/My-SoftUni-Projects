using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemCollection = new AddRemoveCollection();
            MyList myListCollection = new MyList();

            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<int> addCollResults = new List<int>();
            List<int> addRemCollResults = new List<int>();
            List<int> myListResults = new List<int>();

            foreach (var item in strings)
            {
                addCollResults.Add(addCollection.Add(item));
                addRemCollResults.Add(addRemCollection.Add(item));
                myListResults.Add(myListCollection.Add(item));
            }

            int numberOfRemovals = int.Parse(Console.ReadLine());

            List<string> addRemCollRemoveResults = new List<string>();
            List<string> myListRemoveResults = new List<string>();

            for (int i = 0; i < numberOfRemovals; i++)
            {
                addRemCollRemoveResults.Add(addRemCollection.Remove());
                myListRemoveResults.Add(myListCollection.Remove());
            }

            Console.WriteLine(string.Join(" ", addCollResults));
            Console.WriteLine(string.Join(" ", addRemCollResults));
            Console.WriteLine(string.Join(" ", myListResults));
            Console.WriteLine(string.Join(" ", addRemCollRemoveResults));
            Console.WriteLine(string.Join(" ", myListRemoveResults));
        }
    }
}