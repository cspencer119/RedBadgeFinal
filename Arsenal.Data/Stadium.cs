using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Data
{
    public class Stadium
    {
        [Key]
        public int StadiumId { get; set; }
        [Required]
        public string StadiumName { get; set; }
        [Required]
        public string StadiumDescription { get; set; }
        [Required]
        public int StadiumCapacity { get; set; }
        [Required]
        public string StadiumLocation { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }

    public class StadiumDbContext : DbContext
    {
        public DbSet<Stadium> Stadium {get;set;}
    }
}
