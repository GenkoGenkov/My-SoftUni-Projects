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
            var result = GetAddressesByTown(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                                .Include(x => x.Town)
                                .Include(x => x.Employees)
                                .OrderByDescending(x => x.Employees.Count())
                                .ThenBy(x => x.Town.Name)
                                .ThenBy(x => x.AddressText)
                                .Take(10)
                                .ToList();

            return String.Join(
                    Environment.NewLine,
                    addresses.Select(x =>
                        $"{x.AddressText}, {x.Town.Name} - {x.Employees.Count()} employees")
                    );
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employeeId = 147;

            var employee = context.Employees
                            .Include(x => x.EmployeesProjects)
                            .ThenInclude(x => x.Project)
                            .FirstOrDefault(x => x.EmployeeId == employeeId);

            var sb = new StringBuilder();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in employee.EmployeesProjects.OrderBy(x => x.Project.Name))
            {
                sb.AppendLine(project.Project.Name);
            }

            return sb.ToString().TrimEnd();
        }


        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(x => x.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 &&
                                                    p.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    EmployeeFirstName = x.FirstName,
                    EmployeeLastName = x.LastName,
                    ManagerFirstName = x.Manager.FirstName,
                    ManagerLastName = x.Manager.LastName,
                    Projects = x.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    })
                })
                .Take(10)
                .ToList();

            var sb = new StringBuilder();

            foreach (var emp in employees)
            {
                sb.AppendLine($"{emp.EmployeeFirstName} {emp.EmployeeLastName} - Manager: {emp.ManagerFirstName} {emp.ManagerLastName}");

                foreach (var project in emp.Projects)
                {
                    var endDate = project.EndDate.HasValue
                        ? project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                        : "not finished";

                    sb.AppendLine($"--{project.ProjectName} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {endDate}");

                }
            }

            var result = sb.ToString().TrimEnd();

            return result;
    }   }
}
