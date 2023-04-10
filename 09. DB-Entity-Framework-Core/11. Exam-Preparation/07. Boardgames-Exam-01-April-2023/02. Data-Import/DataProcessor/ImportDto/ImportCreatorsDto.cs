using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Creator")]
    public class ImportCreatorsDto
    {
        [XmlElement("FirstName")]
        [Required]
        [StringLength(7, MinimumLength = 2)]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        [Required]
        [StringLength(7, MinimumLength = 2)]
        public string LastName { get; set; }

        [XmlArray("Boardgames")]
        public ImportBoardgamesDto[] Boardgames { get; set; }
    }
}

//⦁	FirstName – text with length [2, 7] (required)
//⦁	LastName – text with length [2, 7] (required)
