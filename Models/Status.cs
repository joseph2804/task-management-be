using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    [Table("Status")]
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        
        public virtual ICollection<Mission> Missions { get; set; }
    }
}
