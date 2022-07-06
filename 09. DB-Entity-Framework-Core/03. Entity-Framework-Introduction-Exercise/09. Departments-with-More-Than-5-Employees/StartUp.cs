using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var softUniContext = new SoftUniContext();
            var result = GetDepartmentsWithMoreThan5Employees(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                                .Include(x => x.Employees)
                                .ThenInclude(x => x.Manager)
                                .Where(x => x.Employees.Count() > 5)
                                .OrderBy(x => x.Employees.Count())
                                .ThenBy(x => x.Name)
                                .ToList();

            var sb = new StringBuilder();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");

                foreach (var employee in department.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }   
}
