using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal.Models
{
    public class StadiumEdit
    {
        public int StadiumId { get; set; }
        public string StadiumName { get; set; }
        public string StadiumDescription { get; set; }
        public int StadiumCapacity { get; set; }
        public string StadiumLocation { get; set; }
    }
}
