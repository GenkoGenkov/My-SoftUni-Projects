using CarDealer.XMLHelper;
using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Models;
using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var usersXml = File.ReadAllText("./Datasets/users.xml");

            Console.WriteLine(ImportUsers(context, usersXml));
        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            const string root = "Users";

            var usersDto = XmlConverter.Deserializer<UsersImportModel>(inputXml, root);

            var users = usersDto.Select(s => new User
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age
            });

            context.Users.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count()}";
        }
    }
}