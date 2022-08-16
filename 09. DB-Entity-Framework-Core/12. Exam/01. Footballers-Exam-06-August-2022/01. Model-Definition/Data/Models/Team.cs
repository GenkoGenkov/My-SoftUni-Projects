using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models
{
    public class Team
    {
        public Team()
        {
            TeamsFootballers = new HashSet<TeamFootballer>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.TeamNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.NationalityMaxLength)]
        public string Nationality { get; set; }

        public int Trophies { get; set; }

        public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; }
    }
}
