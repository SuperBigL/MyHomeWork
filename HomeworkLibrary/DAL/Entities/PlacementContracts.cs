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
   public class PlacementContracts
    {
       [Key]
       public int PlacementContractID { get; set; }
       [Required (ErrorMessage="You need a start Date")]
       public DateTime StartDate { get; set; }
       [Required(ErrorMessage="You need an end date.")]
       public DateTime EndDate { get; set; }
       [Required(ErrorMessage="You need a Location ID")]
       public int LocationID { get; set; }


       public virtual ICollection<Location> LocationList { get; set; }
       public virtual ICollection<Shifts> ShiftList { get; set; }
       public virtual ICollection<Employees> EmployeeList { get; set; }
       public virtual ICollection<Schedules> ScheduleList { get; set; }
       public virtual ICollection<Skills> SkillList { get; set; }
    }
}
