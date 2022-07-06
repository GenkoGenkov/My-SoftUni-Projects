using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Collections.Generic;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var softUniContext = new SoftUniContext();
            var result = IncreaseSalaries(softUniContext);
            Console.WriteLine(result);
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var departmentsArray = new List<string>()
            {
                "Engineering",
                "Tool Design",
                "Marketing",
                "Information Services"
            };

            var employeesToPromote = context.Employees
                                        .Include(x => x.Department)
                                        .Where(x => departmentsArray.Contains(x.Department.Name))
                                        .OrderBy(x => x.FirstName)
                                        .ThenBy(x => x.LastName)
                                        .ToList();

            var sb = new StringBuilder();

            foreach (var employee in employeesToPromote)
            {
                employee.Salary *= 1.12M;

                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }
    }   
}
