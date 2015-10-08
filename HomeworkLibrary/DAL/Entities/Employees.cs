using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using HomeworkLibrary.Entities;
using HomeworkLibrary.BAL.Entities;

namespace HomeworkLibrary
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage="You Need a first name")]
        [StringLength(50, ErrorMessage="The First Name must be between 1 and 50 alphabetical letters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="You need a last name.")]
        [StringLength(50, ErrorMessage = "The Last Name must be between 1 and 50 alphabetical letters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage="You need a phone number."), Range(10,12,ErrorMessage="The Phone Number must be between 10 and 12 numbers.")]
        public string HomePhone { get; set; }
        [Required(ErrorMessage="Is the employee active or not?")]
        public bool Active { get; set; }

        public virtual ICollection<Location> LocationList { get; set; }
        public virtual ICollection<Shifts> ShiftList { get; set; }
        public virtual ICollection<PlacementContracts> PCList { get; set; }
        public virtual ICollection<Schedules> ScheduleList { get; set; }
        public virtual ICollection<Skills> SkillList { get; set; }
    }
}
