using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Models
{
    public class Appoimtment
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public ModelCar Car { get; set; }
        public List<string> ServicesType { get; set; }
    }
}
