using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AutoRepair.Entities
{
    [Table("Discounts")]
    public class Discount
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Count { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<UserDiscount> UserDiscount{ get; set; }
    }
}
