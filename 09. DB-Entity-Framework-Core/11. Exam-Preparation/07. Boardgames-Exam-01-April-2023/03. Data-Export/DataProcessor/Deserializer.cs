namespace Boardgames.DataProcessor
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Boardgames.Data;
    using Boardgames.Data.Models;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var xmlSerializer = new XmlSerializer(typeof(ImportCreatorsDto[]),
                new XmlRootAttribute("Creators"));

            var creatorsDto = (ImportCreatorsDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            ICollection<Creator> valid = new HashSet<Creator>();

            foreach (var creator in creatorsDto)
            {
                if (!IsValid(creator))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                ICollection<Boardgame> validGames = new HashSet<Boardgame>();

                foreach (var game in creator.Boardgames)
                {
                    if (!IsValid(game))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Boardgame boardgame = new Boardgame()
                    {
                        Name = game.Name,
                        Rating = game.Rating,
                        YearPublished = game.YearPublished,
                        CategoryType = (CategoryType)game.CategoryType,
                        Mechanics = game.Mechanics
                    };


                    validGames.Add(boardgame);
                }

                Creator creator1 = new Creator()
                {
                    FirstName = creator.FirstName,
                    LastName = creator.LastName,
                    Boardgames = validGames
                };

                valid.Add(creator1);

                sb.AppendLine(String.Format(SuccessfullyImportedCreator, creator1.FirstName, creator1.LastName, creator1.Boardgames.Count));
            }

            context.Creators.AddRange(valid);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            var sellersDtos = JsonConvert.DeserializeObject<IEnumerable<ImportsellersDto>>(jsonString);

            var sellers = new List<Seller>();

            var sb = new StringBuilder();

            foreach (var seller in sellersDtos)
            {
                if (!IsValid(seller))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Seller s = new Seller
                {
                    Name = seller.Name,
                    Address = seller.Address,
                    Country = seller.Country,
                    Website = seller.Website
                };

                List<BoardgameSeller> boardgameSellers = new List<BoardgameSeller>();

                foreach (var item in seller.Boardgames.Distinct())
                {
                    Boardgame boardgame = context.Boardgames.Find(item);

                    if (boardgame == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    BoardgameSeller bs = new BoardgameSeller
                    {
                        Boardgame = boardgame,
                        Seller = s
                    };

                    boardgameSellers.Add(bs);
                }

                s.BoardgamesSellers = boardgameSellers;

                sellers.Add(s);

                sb.AppendLine(String.Format(SuccessfullyImportedSeller, seller.Name, boardgameSellers.Count));
            }

            context.AddRange(sellers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
