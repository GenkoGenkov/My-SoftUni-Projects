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
            var result = RemoveTown(softUniContext);
            Console.WriteLine(result);
        }

        public static string RemoveTown(SoftUniContext context)
        {
            var town = context.Towns.FirstOrDefault(x => x.Name == "Seattle");

            var addresses = context.Addresses
                                    .Where(x => x.TownId == town.TownId);

            var employees = context.Employees
                                    .Where(x => addresses.Any(y => y.AddressId == x.AddressId))
                                    .ToList();

            employees.ForEach(x => x.AddressId = null);

            context.SaveChanges();

            var deletedTownsCount = addresses.Count();

            context.Addresses.RemoveRange(addresses);
            context.SaveChanges();

            context.Towns.Remove(town);
            context.SaveChanges();

            return $"{deletedTownsCount} addresses in Seattle were deleted";
        }
    }   
}
