using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public int FirstName { get; set; }

        [MaxLength(200)]
        public int SecondName { get; set; }

        [Required]
        [MaxLength(200)]
        public int Email { get; set; }

        [MaxLength(200)]
        public int PhoneNumber { get; set; }
    }
}
