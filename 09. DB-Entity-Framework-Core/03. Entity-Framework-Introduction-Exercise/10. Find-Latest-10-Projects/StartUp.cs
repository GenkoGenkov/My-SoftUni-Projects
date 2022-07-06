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
            var result = GetLatestProjects(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var lastTenProjects = context.Projects
                                        .OrderByDescending(x => x.StartDate)
                                        .Take(10)
                                        .OrderBy(x => x.Name)
                                        .ToList();

            var sb = new StringBuilder();
            foreach (var project in lastTenProjects)
            {
                sb.AppendLine(project.Name);
                sb.AppendLine(project.Description);
                sb.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return sb.ToString().TrimEnd();
        }
    }   
}
