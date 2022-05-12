using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models.Stadium
{
    public class StadiumListItem
    {
        [Display(Name = "Stadium Id")]
        public int StadiumId { get; set; }
        [Display(Name = "Stadium Name")]
        public string StadiumName { get; set; }
        [Display(Name = "Stadium Capactiy")]
        public int StadiumCapacity { get; set; }
        [Display(Name = "Stadium Location")]
        public string StadiumLocation { get; set; }
        public override string ToString() => StadiumName;
    }
}
