using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class StadiumCreate
    {
        [MaxLength(60, ErrorMessage = "There are too many characters in this field. (Max 60)")]
        [Required]
        public string StadiumName { get; set; }
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field. (Max 1000")]
        [Required]
        public string StadiumDescription { get; set; }
        [Required]
        public int StadiumCapacity { get; set; }
        [Required]
        public string StadiumLocation { get; set; }
    }
}
