using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HomeworkLibrary.Entities;

namespace HomeworkLibrary.BAL.Entities
{
    public class Schedules
    {
        [Key]
        public int ScheduleID { get; set; }
        [Required(ErrorMessage="You must enter a day of the week")]
        public DateTime Day { get; set; }
         [Required(ErrorMessage = "You need a Shift ID")]
        public int ShiftID { get; set; }
        [Required(ErrorMessage="You need an Employee ID")]
        public int EmployeeID { get; set; }

        public virtual Employees Employee { get; set; }
        public virtual Shifts Shift { get; set; }
    }
}
