using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {

        public static void Main(string[] args)
        {
            var context = new CarDealerContext();

            Console.WriteLine(GetTotalSalesByCustomer(context));
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                                   .Where(c => c.Sales.Count >= 1)
                                   .Select(i => new
                                   {
                                       fullName = i.Name,
                                       boughtCars = i.Sales.Count,
                                       spentMoney = i.Sales
                                                     .Sum(c => c.Car.PartCars
                                                                  .Sum(p => p.Part.Price))
                                   })
                                   .OrderByDescending(x => x.spentMoney)
                                   .ThenByDescending(x => x.boughtCars)
                                   .ToList();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

    }

}       