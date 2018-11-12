using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Entities
{
    [Table("AppoimtmentServiceTypes")]
    public class AppoimtmentServiceType
    {
        [Key]
        public int Id { get; set; }
        public int AppoimtmentId { get; set; }
        public Appoimtment Appoimtment { get; set; }
        [MaxLength(20)]
        public string ServiceType { get; set; }
    }
}
