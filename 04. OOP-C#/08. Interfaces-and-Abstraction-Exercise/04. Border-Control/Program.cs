using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            string input = Console.ReadLine();

            IIdentifiable newEntry = null;

            while (input != "End")
            {
                string[] inputInfo = input.Split();

                if (inputInfo.Length == 2)
                {
                    string model = inputInfo[0];
                    string id = inputInfo[1];

                    newEntry = new Robot(id, model);
                }
                else if (inputInfo.Length == 3)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string id = inputInfo[2];

                    newEntry = new Citizen(id, name, age);
                }

                identifiables.Add(newEntry);

                input = Console.ReadLine();
            }

            string endDigits = Console.ReadLine();

            foreach (var item in identifiables)
            {
                if (item.Id.EndsWith(endDigits))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}