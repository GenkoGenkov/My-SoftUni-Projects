using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Footballers.DataProcessor.ImportDto
{
    public class ImportTeamFootballersDto
    {
        [Required]
        [MinLength(GlobalConstants.TeamNameMinLength)]
        [MaxLength(GlobalConstants.TeamNameMaxLength)]
        [RegularExpression(GlobalConstants.TeamNameRegex)]
        public string Name { get; set; }

        [Required]
        [MinLength(GlobalConstants.NationalityMinLength)]
        [MaxLength(GlobalConstants.NationalityMaxLength)]
        public string Nationality { get; set; }

        [Range(typeof(int),GlobalConstants.TeamTrophiesMinValue,GlobalConstants.TeamTrophiesMaxValue)]
        public int Trophies { get; set; }

        [MinLength(1)]
        public int[] Footballers { get; set; }
    }
}
