using Boardgames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportsellersDto
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Address { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [RegularExpression("[www.]{4}[a-zA-Z0-9-]*.{1}[com]+")]
        public string Website { get; set; }

        public IEnumerable<int> Boardgames { get; set; }
    }
}

//⦁	Name – text with length [5…20] (required)
//⦁	Address – text with length [2…30] (required)
//⦁	Country – text(required)
//⦁	Website – a string(required).First four characters are "www.",
//followed by upper and lower letters, digits or '-' and the last three characters are ".com".
