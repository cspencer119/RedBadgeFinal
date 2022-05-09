using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class ResultsDetail
    {
        [Display(Name = "Home Team")]
        public string HomeTeamName { get; set; }
        [Display(Name = "Away Team")]
        public string AwayTeamName { get; set; }
        [Display(Name = "Home Team Score")]
        public int HomeTeamScore { get; set; }
        [Display(Name = "Away Team Score")]
        public int AwayTeamScore { get; set; }
        [Display(Name = "Who Scored")]
        public string WhoScored { get; set; }
        [Display(Name = "Fan Attendance")]
        public int FanAttendance { get; set; }
        [Display(Name = "Competition")]
        public string CompetitionName { get; set; }
    }
}
