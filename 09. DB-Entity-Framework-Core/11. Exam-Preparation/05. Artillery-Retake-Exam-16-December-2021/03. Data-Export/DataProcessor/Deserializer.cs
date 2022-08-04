namespace Artillery.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage =
                "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            var sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCountriesDtoModel[]), new XmlRootAttribute("Countries"));

            using StringReader sr = new StringReader(xmlString);

            ImportCountriesDtoModel[] countryDtos = (ImportCountriesDtoModel[])xmlSerializer.Deserialize(sr);

            List<Country> countries = new List<Country>();

            foreach (var currentCountry in countryDtos)
            {
                if (!IsValid(currentCountry))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Country country = new Country()
                {
                    CountryName = currentCountry.CountryName,
                    ArmySize = currentCountry.ArmySize
                };

                countries.Add(country);

                sb.AppendLine(String.Format(SuccessfulImportCountry, currentCountry.CountryName, currentCountry.ArmySize));
            }

            context.Countries.AddRange(countries);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Manufacturers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportManufacturersDtoModel[]), xmlRoot);

            StringReader stringReader = new StringReader(xmlString);

            ImportManufacturersDtoModel[] manufacturerDtos = (ImportManufacturersDtoModel[])xmlSerializer.Deserialize(stringReader);

            ICollection<Manufacturer> manufacturers = new HashSet<Manufacturer>();

            foreach (var dto in manufacturerDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (manufacturers.Any(m => m.ManufacturerName == dto.ManufacturerName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string[] foundedDataArray = dto.Founded.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (foundedDataArray.Length < 2)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string countryName = foundedDataArray[foundedDataArray.Length - 1];
                string townName = foundedDataArray[foundedDataArray.Length - 2];

                Manufacturer manufacturer = new Manufacturer()
                {
                    ManufacturerName = dto.ManufacturerName,
                    Founded = dto.Founded
                };

                manufacturers.Add(manufacturer);

                sb.AppendLine(string.Format(SuccessfulImportManufacturer, manufacturer.ManufacturerName, $"{townName}, {countryName}"));
            }

            context.AddRange(manufacturers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Shells");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportShellDtoModel[]), xmlRoot);

            StringReader stringReader = new StringReader(xmlString);

            ImportShellDtoModel[] shellDtos = (ImportShellDtoModel[])xmlSerializer.Deserialize(stringReader);

            ICollection<Shell> shells = new HashSet<Shell>();

            foreach (var currentShell in shellDtos)
            {
                if (!IsValid(currentShell))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Shell shell = new Shell()
                {
                    ShellWeight = currentShell.ShellWeight,
                    Caliber = currentShell.Caliber
                };

                shells.Add(shell);

                sb.AppendLine($"Successfully import shell caliber #{currentShell.Caliber} weight {currentShell.ShellWeight} kg.");
            }

            context.AddRange(shells);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<ImportGunsDtoModel> gunDtos = JsonConvert.DeserializeObject<IEnumerable<ImportGunsDtoModel>>(jsonString);

            ICollection<Gun> guns = new HashSet<Gun>();

            foreach (var dto in gunDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool hasGunType = Enum.TryParse<GunType>(dto.GunType, true, out GunType gunType);

                if (!hasGunType)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Gun gun = new Gun()
                {
                    ManufacturerId = dto.ManufacturerId,
                    GunWeight = dto.GunWeight,
                    BarrelLength = dto.BarrelLength,
                    NumberBuild = dto.NumberBuild,
                    Range = dto.Range,
                    GunType = gunType,
                    ShellId = dto.ShellId
                };

                HashSet<CountryGun> countryGuns = new HashSet<CountryGun>();

                foreach (var countryId in dto.Countries)
                {
                    Country country = context.Countries.FirstOrDefault(c => c.Id == countryId.Id);

                    CountryGun countryGun = new CountryGun()
                    {
                        Gun = gun,
                        Country = country
                    };

                    countryGuns.Add(countryGun);
                }

                gun.CountriesGuns = countryGuns;

                guns.Add(gun);

                sb.AppendLine(string.Format(SuccessfulImportGun, gun.GunType, gun.GunWeight, gun.BarrelLength));
            }

            context.AddRange(guns);

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
