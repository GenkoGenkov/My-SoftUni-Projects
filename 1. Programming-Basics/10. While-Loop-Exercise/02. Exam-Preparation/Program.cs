using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();

            int countBadGrades = 0;
            int gradesCounter = 0;
            int scoreCounter = 0;
            string lastProblemName = "";

            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                scoreCounter += grade;
                gradesCounter++;

                if (grade <= 4)
                {
                    countBadGrades++;

                    if (countBadGrades == badGrades)
                    {
                        break;
                    }
                }

                lastProblemName = problemName;
                problemName = Console.ReadLine();

            }

            if (problemName == "Enough")
            {
                double averageScore = 1.0 * scoreCounter / gradesCounter;

                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {gradesCounter}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
            }
        }
    }
}
