using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Data
{
    public class Results
    {
        [Key]
        public int ResultId { get; set; }
        
        [Required]
        public string HomeTeamName { get; set; }
        [Required]
        public string AwayTeamName { get; set; }
        [Required]
        public int HomeTeamScore { get; set; }
        [Required]
        public int AwayTeamScore { get; set; }
        public string WhoScored { get; set; }
        public int FanAttendance { get; set; }
        public string CompetitionName { get; set; }
        public string Stadium { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }

    public class ResultsDbContext : DbContext
    {
        public DbSet<Results> Results { get; set; }
    }
}
