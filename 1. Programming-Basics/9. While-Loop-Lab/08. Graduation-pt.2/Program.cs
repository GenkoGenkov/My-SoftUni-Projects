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
            string name = Console.ReadLine();

            int years = 1;
            double averageScore = 0;
            int badGrades = 0;

            while (years <= 12)
            {
                double yearsScore = double.Parse(Console.ReadLine());


                if (yearsScore >= 4.00)
                {
                    averageScore = averageScore + yearsScore;
                    years++;
                }

                if (yearsScore < 4.00)
                {
                    badGrades++;

                    if (badGrades > 1)
                    {
                        break;
                    }
                }

            }

            if (years == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageScore / 12:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {years} grade");
            }
        }
    }
}
