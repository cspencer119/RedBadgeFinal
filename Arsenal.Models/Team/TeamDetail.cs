using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class TeamDetail
    {
        [Display(Name = "Team ID")]
        public int TeamId { get; set; }
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Display(Name = "Team Description")]
        public string TeamDescription { get; set; }
        [Display(Name = "Team Stadium")]
        public string Stadium { get; set; }
        [Display(Name = "Stadium ID")]
        public int StadiumID { get; set; }
    }
}
