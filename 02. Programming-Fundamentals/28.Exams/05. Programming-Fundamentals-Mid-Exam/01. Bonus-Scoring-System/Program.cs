using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            double maxStudentBonus = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount * (5 + initialBonus);

                if (totalBonus > maxStudentBonus)
                {
                    maxStudentBonus = totalBonus;
                    maxStudentAttendance = studentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxStudentBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentAttendance} lectures.");
        }
    }
}
