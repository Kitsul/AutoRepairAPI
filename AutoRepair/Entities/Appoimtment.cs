using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("Appoimtments")]
    public class Appoimtment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [MaxLength(200)]
        public string Message { get; set; }
        public ModelCar Car { get; set; }
        public string YearCar { get; set; }
        public ICollection<AppoimtmentServiceType> AppoimtmentServiceType { get; set; } = new List<AppoimtmentServiceType>();

    }
}
