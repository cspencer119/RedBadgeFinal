using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class ResultsEdit
    {
        public int ResultId { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public string WhoScored { get; set; }
        public int FanAttendance { get; set; }
        public string CompetitionName { get; set; }
    }
}
