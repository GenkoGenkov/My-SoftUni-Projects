using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO.Input;
using CarDealer.Models;
using CarDealer.XmlHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        static IMapper mapper;

        public static void Main(string[] args)
        {
            var context = new CarDealerContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var suppliersXml = File.ReadAllText("./Datasets/suppliers.xml");
            var partsXml = File.ReadAllText("./Datasets/parts.xml");
            var carsXml = File.ReadAllText("./Datasets/cars.xml");
            var customersXml = File.ReadAllText("./Datasets/customers.xml");

            ImportSuppliers(context, suppliersXml);
            ImportParts(context, partsXml);
            ImportCars(context, carsXml);

            var result = ImportCustomers(context, customersXml);

            System.Console.WriteLine(result);
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            const string root = "Customers";

            InitializeAutoMapper();

            var customersDto = XmlConverter.Deserializer<CustomerInputModel>(inputXml, root);

            var customers = mapper.Map<Customer[]>(customersDto);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count()}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            const string root = "Cars";

            var cars = new List<Car>();

            var carsDto = XmlConverter.Deserializer<CarInputModel>(inputXml, root);

            var allParts = context.Parts.Select(x => x.Id).ToList();

            foreach (var currentCar in carsDto)
            {
                var distinctedParts = currentCar.CarPartsInputModel.Select(x => x.Id).Distinct();
                var parts = distinctedParts.Intersect(allParts);

                var car = new Car
                {
                    Make = currentCar.Make,
                    Model = currentCar.Model,
                    TravelledDistance = currentCar.TraveledDistance
                };

                foreach (var part in parts)
                {
                    var partCar = new PartCar
                    {
                        PartId = part
                    };

                    car.PartCars.Add(partCar);
                }

                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count()}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            const string root = "Parts";

            var partsDto = XmlConverter.Deserializer<PartInputModel>(inputXml, root);

            var supplierIds = context.Suppliers.Select(x => x.Id).ToList();

            var parts = partsDto
                .Where(s => supplierIds.Contains(s.SupplierId))
                .Select(x => new Part
                {
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    SupplierId = x.SupplierId
                })
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            const string root = "Suppliers";

            var suppliersDto = XmlConverter.Deserializer<SupplierInputModel>(inputXml, root);

            var suppliers = suppliersDto.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.IsImporter
            })
            .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}";
        }

        private static void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }
    }
}