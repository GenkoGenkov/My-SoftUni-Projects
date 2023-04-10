namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Numerics;
    using System.Text;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            var sb = new StringBuilder();

            var result = context
                .Creators
                .Where(c => c.Boardgames.Any())
                .ToArray()
                .Select(c => new ExportCreatorsDto
                {
                    CreatorName = c.FirstName + " " + c.LastName,
                    BoardgamesCount = c.Boardgames.Count().ToString(),
                    Boardgames = c.Boardgames
                        .Select(bg => new ExportBoardgamesDto
                        {
                            BoardgameName = bg.Name,
                            BoardgameYearPublished = bg.YearPublished
                        })
                        .OrderBy(bg => bg.BoardgameName)
                        .ToArray()
                })
                .OrderByDescending(c => c.Boardgames.Count())
                .ThenBy(c => c.CreatorName)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCreatorsDto[]), new XmlRootAttribute("Creators"));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            using (StringWriter stringWriter = new StringWriter(sb))
            {
                xmlSerializer.Serialize(stringWriter, result, namespaces);
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var result = context
                .Sellers
                .Where(s => s.BoardgamesSellers.Any(bg => bg.Boardgame.YearPublished >= year && bg.Boardgame.Rating <= rating))
                .ToArray()
                .Select(s => new
                {
                    Name = s.Name,
                    Website = s.Website,
                    Boardgames = s.BoardgamesSellers
                    .Where(x => x.Boardgame.YearPublished >= year && x.Boardgame.Rating <= rating)
                    .ToArray()
                    .Select(x => new
                    {
                        Name = x.Boardgame.Name,
                        Rating = x.Boardgame.Rating,
                        Mechanics = x.Boardgame.Mechanics,
                        Category = x.Boardgame.CategoryType.ToString(),
                    })
                    .OrderByDescending(x => x.Rating)
                    .ThenBy(x => x.Name)
                    .ToArray()
                })
                .OrderByDescending(s => s.Boardgames.Count())
                .ThenBy(s => s.Name)
                .Take(5)
                .ToArray();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);

            return json;
        }
    }
}