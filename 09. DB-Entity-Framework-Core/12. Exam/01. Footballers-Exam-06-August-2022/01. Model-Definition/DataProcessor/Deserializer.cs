namespace Footballers.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Footballers.Data.Models;
    using Footballers.Data.Models.Enums;
    using Footballers.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCoach
            = "Successfully imported coach - {0} with {1} footballers.";

        private const string SuccessfullyImportedTeam
            = "Successfully imported team - {0} with {1} footballers.";

        public static string ImportCoaches(FootballersContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCoachFootballersDto[]), new XmlRootAttribute("Coaches"));

            List<Coach> coaches = new List<Coach>();

            using StringReader stringReader = new StringReader(xmlString);

            ImportCoachFootballersDto[] coachesDtos = (ImportCoachFootballersDto[])xmlSerializer.Deserialize(stringReader);

            foreach (var cDto in coachesDtos)
            {
                if(!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var coach = new Coach
                {
                    Name = cDto.Name,
                    Nationality = cDto.Nationality
                };

                foreach (var fDto in cDto.Footballers)
                {
                    if(!IsValid(fDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    var isContractStartDateValid = DateTime.TryParseExact(fDto.ContractStartDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime contractStartDate);
                    if(!isContractStartDateValid)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    var isContractEndDateValid = DateTime.TryParseExact(fDto.ContractEndDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime contractEndDate);
                    if (!isContractEndDateValid)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if(contractStartDate > contractEndDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (!Enum.IsDefined(typeof(BestSkillType),fDto.BestSkillType))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (!Enum.IsDefined(typeof(PositionType), fDto.PositionType))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    var footballer = new Footballer
                    {
                        Name = fDto.Name,
                        ContractStartDate = contractStartDate,
                        ContractEndDate = contractEndDate,
                        BestSkillType = (BestSkillType)fDto.BestSkillType,
                        PositionType = (PositionType)fDto.PositionType
                    };
                    coach.Footballers.Add(footballer);
                }
                coaches.Add(coach);
                sb.AppendLine(string.Format(SuccessfullyImportedCoach, coach.Name, coach.Footballers.Count));
            }
            context.Coaches.AddRange(coaches);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        public static string ImportTeams(FootballersContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportTeamFootballersDto[] teamDtos = JsonConvert.DeserializeObject<ImportTeamFootballersDto[]>(jsonString);

            List<Team> teams = new List<Team>();

            foreach (var tDto in teamDtos)
            {
                if(!IsValid(tDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var team = new Team
                {
                    Name = tDto.Name,
                    Nationality = tDto.Nationality,
                    Trophies = tDto.Trophies
                };
                foreach (var fId in tDto.Footballers.Distinct())
                {
                    var footballer = context.Footballers.FirstOrDefault(f => f.Id == fId);
                    if(footballer == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    var teamFootballer = new TeamFootballer
                    {
                        Team = team,
                        Footballer = footballer
                    };
                    team.TeamsFootballers.Add(teamFootballer);
                }
                teams.Add(team);
                sb.AppendLine(string.Format(SuccessfullyImportedTeam, team.Name, team.TeamsFootballers.Count));
            }
            context.Teams.AddRange(teams);
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
