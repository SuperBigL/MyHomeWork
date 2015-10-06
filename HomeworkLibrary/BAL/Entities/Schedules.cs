using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeworkLibrary.BAL.Entities
{
    class Schedules
    {
        [Key]
        public int ScheduleID { get; set; }
        public DateTime Day { get; set; }
        public int ShiftID { get; set; }
        public int EmployeeID { get; set; }
    }
}
