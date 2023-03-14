using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    [Table("AssignedTasks")]
    public class AssignedTask
    {
        [Key]
        public int AssignedTaskID { get; set; }
        public int TaskID { get; set; }

        [ForeignKey("TaskID")]
        public virtual Mission Mission { get; set; }
        public int EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }
    }
}
