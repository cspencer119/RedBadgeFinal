using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Data
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamDescription { get; set; }
        [Required]
        public string Stadium { get; set; }
        [Required]
        public int StadiumId { get; set; }
    }

    public class TeamDbContext : DbContext
    {
        public DbSet<Teams> Teams { get; set; }
    }
}
