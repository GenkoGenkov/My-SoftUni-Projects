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
            var result = GetEmployeesByFirstNameStartingWithSa(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees.ToList();

            return string
                .Join(
                        Environment.NewLine,
                        employees
                        .Where(x => x.FirstName.StartsWith("sa", StringComparison.OrdinalIgnoreCase))
                        .OrderBy(x => x.FirstName)
                        .ThenBy(x => x.LastName)
                        .Select(x =>
                            $"{x.FirstName} {x.LastName} - {x.JobTitle} - (${x.Salary:f2})")
                    );
        }
    }   
}
