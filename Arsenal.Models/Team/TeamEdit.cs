using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class TeamEdit
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string CharacterDescription { get; set; }
        public string Stadium { get; set; }
        public int StadiumID { get; set; }
    }
}
