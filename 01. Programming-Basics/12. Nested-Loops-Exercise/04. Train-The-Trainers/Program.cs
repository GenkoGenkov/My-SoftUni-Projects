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
            int jouryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double sumOfGrades = 0;

                for (int i = 1; i <= jouryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    sumOfGrades += grade;
                    sumOfAllGrades += grade;
                    gradeCount++;
                }

                double average = sumOfGrades / jouryCount;

                Console.WriteLine($"{input} - {average:F2}.");
                input = Console.ReadLine();
            }

            double averageFinal = sumOfAllGrades / gradeCount;

            Console.WriteLine($"Student's final assessment is {averageFinal:F2}.");
        }
    }
}

