using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class ResultsCreate
    {
        [Required]
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
        [Required]
        public string CompetitionName { get; set; }
    }
}
