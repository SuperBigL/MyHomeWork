﻿using System;
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
        public DateTime Day { get; set; }
         [Required(ErrorMessage = "You need a Shift ID")]
        public int ShiftID { get; set; }
        [Required(ErrorMessage="You need an Employee ID")]
        public int EmployeeID { get; set; }

        public virtual ICollection<Location> LocationList { get; set; }
        public virtual ICollection<Shifts> ShiftList { get; set; }
        public virtual ICollection<Employees> EmployeeList { get; set; }
        public virtual ICollection<PlacementContracts> PCList { get; set; }
        public virtual ICollection<Skills> SkillList { get; set; }
    }
}
