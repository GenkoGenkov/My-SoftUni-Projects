using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split(" : ");

                string courseName = data[0];
                string studentName = data[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                    command = Console.ReadLine();
                    continue;
                }

                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var users in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{users.Key}: {users.Value.Count}");
                users.Value.Sort();
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", users.Value));
            }
        }
    }
}