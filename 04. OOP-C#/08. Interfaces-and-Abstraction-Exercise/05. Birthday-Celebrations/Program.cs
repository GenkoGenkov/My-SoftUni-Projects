using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;

            List<ICelebratable> detainedTypes = new List<ICelebratable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] borderControlInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = borderControlInfo[0];
                string name = borderControlInfo[1];

                switch (type)
                {
                    case "Citizen":
                        int age = int.Parse(borderControlInfo[2]);
                        string id = borderControlInfo[3];
                        string birthdate = borderControlInfo[4];

                        Citizen currCitizen = new Citizen(name, age, id, birthdate);

                        detainedTypes.Add(currCitizen);
                        break;
                    case "Pet":
                        birthdate = borderControlInfo[2];

                        Pet currPet = new Pet(name, birthdate);

                        detainedTypes.Add(currPet);
                        break;
                }
            }

            string specificYearEndingNumber = Console.ReadLine();

            foreach (var celebratable in detainedTypes)
            {
                if (celebratable.Birthdate.EndsWith(specificYearEndingNumber))
                {
                    Console.WriteLine(celebratable.Birthdate);
                }
            }
        }
    }
}