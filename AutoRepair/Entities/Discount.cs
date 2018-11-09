using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Entities
{
    [Table("Discounts")]
    public class Discount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public decimal Count { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<UserDiscountService> UserDiscountServices { get; set; }
    }
}
