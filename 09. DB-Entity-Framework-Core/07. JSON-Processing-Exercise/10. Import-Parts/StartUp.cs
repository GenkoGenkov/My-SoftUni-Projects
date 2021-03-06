using System;
using System.Collections.Generic;
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

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var suppliersJson = File.ReadAllText("../../../Datasets/suppliers.json");
            var partsJson = File.ReadAllText("../../../Datasets/parts.json");

            Console.WriteLine(ImportSuppliers(context, suppliersJson));
            Console.WriteLine(ImportParts(context, partsJson));
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var suppliedIds = context.Suppliers.Select(x => x.Id).ToList();

            var parts = JsonConvert
                .DeserializeObject<IEnumerable<Part>>(inputJson)
                .Where(s => suppliedIds.Contains(s.SupplierId))
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}.";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var supplierDtos = JsonConvert.DeserializeObject<IEnumerable<ImportSupplierInputModel>>(inputJson);

            var suppliers = supplierDtos.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.isImporter
            })
            .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}.";
        }
    }
}