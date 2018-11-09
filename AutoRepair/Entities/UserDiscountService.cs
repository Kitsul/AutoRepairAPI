using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Entities
{
    public class UserDiscountService
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DiscountId { get; set; }
        public Discount Discount { get; set; }
        public Guid ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
