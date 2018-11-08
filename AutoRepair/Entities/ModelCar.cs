using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("ModelsCar")]
    public class ModelCar
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public int Name { get; set; }
    }
}
