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

            Dictionary<string, Predicate<string>> dictionary = new Dictionary<string, Predicate<string>>();

            string command = Console.ReadLine();

            while (command != "Print")
            {
                string[] commandArgs = command.Split(';');

                string action = commandArgs[0];
                string predicateAction = commandArgs[1];
                string value = commandArgs[2];
                string key = predicateAction + value;

                if (action == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicateAction, value);

                    dictionary.Add(key, predicate);
                }
                else if (action == "Remove filter")
                {
                    dictionary.Remove(key);
                }

                command = Console.ReadLine();
            }

            foreach (var (key, predicate) in dictionary)
            {
                names.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static Predicate<string> GetPredicate(string info, string param)
        {
            if (info == "Starts with")
            {
                return x => x.StartsWith(param);
            }

            if (info == "Ends with")
            {
                return x => x.EndsWith(param);
            }

            if (info == "Contains")
            {
                return x => x.Contains(param);
            }

            int lenght = int.Parse(param);

            return x => x.Length == lenght;
        }
    }
}