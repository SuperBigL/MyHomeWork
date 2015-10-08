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
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }
        [Required(ErrorMessage="You need a description"), Range(1, 100, ErrorMessage= "Description must be between 1 and 100 characters")]
        public string Description { get; set; }
        [Required(ErrorMessage="Does it require a Ticket or not?")]
        public bool RequiresTicket { get; set; }


        public virtual ICollection<Location> LocationList { get; set; }
        public virtual ICollection<PlacementContracts> PCList { get; set; }
        public virtual ICollection<Employees> EmployeeList { get; set; }
        public virtual ICollection<Schedules> ScheduleList { get; set; }
        public virtual ICollection<Skills> SkillList { get; set; }
    }
}
