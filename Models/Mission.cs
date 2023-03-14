using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    [Table("Missions")]
    public class Mission
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        [ForeignKey("StatusID")]
        public int StatusID { get; set; }
        public string Note { get; set; }
        public virtual ICollection<AssignedTask> AssignedTasks { get; set; }

        public virtual Status Status { get; set; }
    }
}
