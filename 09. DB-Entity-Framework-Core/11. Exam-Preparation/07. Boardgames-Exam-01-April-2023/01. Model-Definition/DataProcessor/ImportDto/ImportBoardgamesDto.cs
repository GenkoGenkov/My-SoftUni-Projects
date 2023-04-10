using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Boardgame")]
    public class ImportBoardgamesDto
    {
        [XmlElement("Name")]
        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string Name { get; set; }

        [XmlElement("Rating")]
        [Required]
        [Range(1, 10.00)]
        public double Rating { get; set; }

        [XmlElement("YearPublished")]
        [Required]
        [Range(2018, 2023)]
        public int YearPublished { get; set; }

        [XmlElement("CategoryType")]
        [Required]
        public int CategoryType { get; set; }

        [XmlElement("Mechanics")]
        [Required]
        public string Mechanics { get; set; }
    }
}

//⦁	Name – text with length [10…20] (required)
//⦁	Rating – double in range[1…10.00](required)
//⦁	YearPublished – integer in range[2018…2023](required)
//⦁	CategoryType – enumeration of type CategoryType, with possible values (Abstract, Children, Family, Party, Strategy) (required)
//⦁	Mechanics – text(string, not an array)(required)
