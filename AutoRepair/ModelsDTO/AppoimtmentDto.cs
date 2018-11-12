using System.Collections.Generic;

namespace AutoRepair.ModelsDTO
{
    public class AppoimtmentDto
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public UserDto User { get; set; }
        public string Message { get; set; }
        public ModelCarDto Car { get; set; }
        public List<string> ServicesType { get; set; }


    }
}
