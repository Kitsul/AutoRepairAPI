using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Entities
{
    public class UserDiscountService
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
