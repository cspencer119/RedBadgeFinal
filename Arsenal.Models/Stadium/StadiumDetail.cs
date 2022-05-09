using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class StadiumDetail
    {
        [Display(Name = "Stadium ID")]
        public int StadiumId { get; set; }
        [Display(Name = "Stadium Name")]
        public string StadiumName { get; set; }
        [Display(Name = "Stadium Description")]
        public string StadiumDescription { get; set; }
        [Display(Name = "Stadium Capacity")]
        public int StadiumCapacity { get; set; }
        [Display(Name = "Stadium Location")]
        public string StadiumLocation { get; set; }
    }
}
