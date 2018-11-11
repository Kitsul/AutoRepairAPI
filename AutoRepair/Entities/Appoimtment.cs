using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRepair.Entities
{
    [Table("Appoimtments")]
    public class Appoimtment
    {
        [Key]
        public Guid Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
}
