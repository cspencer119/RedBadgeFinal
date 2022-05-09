using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class TeamCreate
    {
        [MaxLength(40, ErrorMessage = "There are too many characters in this field. (Max 40")]
        [Required]
        public string TeamName { get; set; }
        [MaxLength(1500, ErrorMessage = "There are too many characters in this field. (Max 1500")]
        [Required]
        public string TeamDescription { get; set; }
        [Required]
        public string Stadium { get; set; }
        [Required]
        public int StadiumId { get; set; }
    }
}
