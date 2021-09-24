using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {

                string[] data = input.Split("-");
                string username = data[0];
                string programminglanguage = data[1];

                if (programminglanguage == "banned")
                {
                    results.Remove(username);
                    input = Console.ReadLine();
                    continue;
                }

                int points = int.Parse(data[2]);

                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                }
                else if (results[username] < points)
                {
                    results[username] = points;
                }

                if (!submissions.ContainsKey(programminglanguage))
                {
                    submissions.Add(programminglanguage, 0);
                }

                submissions[programminglanguage]++;


                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var (username, points) in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username} | {points}");
            }

            Console.WriteLine("Submissions:");

            foreach (var (language, count) in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}