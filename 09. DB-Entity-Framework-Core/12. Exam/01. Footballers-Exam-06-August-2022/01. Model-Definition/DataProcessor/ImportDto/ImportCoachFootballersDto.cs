using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Coach")]
    public class ImportCoachFootballersDto
    {
        [Required]
        [MinLength(GlobalConstants.CoachNameMinLength)]
        [MaxLength(GlobalConstants.CoachNameMaxLength)]
        [XmlElement("Name")]
        public string Name { get; set; }

        [Required]
        [MinLength(GlobalConstants.NationalityMinLength)]
        [MaxLength(GlobalConstants.NationalityMaxLength)]
        [XmlElement("Nationality")]
        public string Nationality { get; set; }

        [XmlArray("Footballers")]
        public ImportCoachFootballerDto[] Footballers { get; set; }
    }
}
