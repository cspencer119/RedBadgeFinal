using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models.Team
{
    public class TeamListItem
    {
        [Display(Name = "Team Id")]
        public int TeamId { get; set; }
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        public override string ToInt() => TeamName;

    }
}
