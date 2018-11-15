using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoRepair.ModelsDTO
{
    public class AppoimtmentDto
    {
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        [Required]
        public UserDto User { get; set; }
        public string Message { get; set; }
        public ModelCarDto Car { get; set; }
        public List<string> ServicesType { get; set; }


    }
}
