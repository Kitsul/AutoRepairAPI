
using System.ComponentModel.DataAnnotations;

namespace AutoRepair.ModelsDTO
{
    public class UserDto
    {
        [Required]
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
