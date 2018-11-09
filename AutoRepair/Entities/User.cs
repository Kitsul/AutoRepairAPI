using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }

        [MaxLength(200)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string PhoneNumber { get; set; }

        public ICollection<UserDiscountService> UserDiscountServices { get; set; }
        public ICollection<ModelCar> ModelsCar { get; set; }
    }
}
