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
            var result = DeleteProjectById(softUniContext);
            Console.WriteLine(result);
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectId = 2;
            var projectsToDelete = context.EmployeesProjects.Where(x => x.ProjectId == projectId);

            context.EmployeesProjects.RemoveRange(projectsToDelete);
            context.SaveChanges();

            var project = context.Projects.Find(projectId);
            context.Projects.Remove(project);
            context.SaveChanges();

            return String.Join(
                Environment.NewLine,
                context.Projects
                    .Take(10)
                    .Select(x => x.Name));
        }
    }   
}
