using System;
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
        public int Name { get; set; }
    }
}
