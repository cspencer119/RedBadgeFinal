using Arsenal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models.Results
{
    public class ResultListItem
    {
        [Display(Name = "Result ID")]
        public int ResultId { get; set; }
        [Display(Name = "Home Team Name")]
        public string HomeTeamName { get; set; }
        [Display(Name = "Away Team Name")]
        public string AwayTeamName { get; set; }
        [Display(Name = "Home Team Score")]
        public int HomeTeamScore { get; set; }
        [Display(Name = "Away Team Score")]
        public int AwayTeamScore { get; set; }
        [Display(Name = "Who Scored")]
        public string WhoScored { get; set; }
        [Display(Name = "Fan Attendance")]
        public int FanAttendance { get; set; }
        [Display(Name = "Competition Name")]
        public string CompetitionName { get; set; }

        public override int ToInt() => ResultId;
    }
}
