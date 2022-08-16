namespace Footballers.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Footballers.Data.Models.Enums;
    using Footballers.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportCoachesWithTheirFootballers(FootballersContext context)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCoachFootballersDto[]), new XmlRootAttribute("Coaches"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            ExportCoachFootballersDto[] coaches = context
                .Coaches
                .Where(c => c.Footballers.Count > 0)
                .ToArray()
                .Select(c => new ExportCoachFootballersDto()
                {
                    FootballersCount = c.Footballers.Count,
                    CoachName = c.Name,
                    Footballers = c.Footballers
                        .Select(f => new ExportCoachFootballerDto()
                        {
                            Name = f.Name,
                            Position = f.PositionType.ToString()
                        })
                        .OrderBy(f => f.Name)
                        .ToArray()
                })
                .OrderByDescending(c => c.FootballersCount)
                .ThenBy(c => c.CoachName)
                .ToArray();

            using StringWriter stringWriter = new StringWriter(sb);
                xmlSerializer.Serialize(stringWriter, coaches, namespaces);

            return sb.ToString().TrimEnd();
        }

        public static string ExportTeamsWithMostFootballers(FootballersContext context, DateTime date)
        {
            var teams = context
                .Teams
                .Where(t => t.TeamsFootballers.Any(tf => tf.Footballer.ContractStartDate >= date))
                .ToArray()
                .Select(t => new
                {
                    Name = t.Name,
                    Footballers = t.TeamsFootballers
                        .Where(tf => tf.Footballer.ContractStartDate >= date)
                        .OrderByDescending(tf => tf.Footballer.ContractEndDate)
                        .ThenBy(tf => tf.Footballer.Name)
                        .ToArray()
                        .Select(tf => new
                        {
                            FootballerName = tf.Footballer.Name,
                            ContractStartDate = tf.Footballer.ContractStartDate.ToString("MM/dd/yyyy",CultureInfo.InvariantCulture),
                            ContractEndDate = tf.Footballer.ContractEndDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                            BestSkillType = tf.Footballer.BestSkillType.ToString(),
                            PositionType = tf.Footballer.PositionType.ToString()
                        })
                        .ToArray()
                })
                .OrderByDescending(t => t.Footballers.Length)
                .ThenBy(t => t.Name)
                .Take(5)
                .ToArray();

            string json = JsonConvert.SerializeObject(teams, Formatting.Indented);

            return json;
        }
    }
} 
