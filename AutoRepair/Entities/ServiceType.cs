using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("ServicesType")]
    public class ServiceType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(70)]
        public string Name { get; set; }

        public ICollection<UserDiscountService> UserDiscountServices { get; set; }
    }
}
