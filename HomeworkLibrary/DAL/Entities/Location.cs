using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using HomeworkLibrary.BAL.Entities;

namespace HomeworkLibrary.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required(ErrorMessage="Enter the name of the location.")]
        [StringLength(50, ErrorMessage="The name must be between 1 and 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the name of the street.")]
        [StringLength(50, ErrorMessage = "The street name must be between 1 and 50 characters.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Enter the name of the city.")]
        [StringLength(50, ErrorMessage = "The city name must be between 1 and 30 characters.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter the name of the Province.")]
        [StringLength(2, ErrorMessage = "The province must be 2 characters")]
        public char Province { get; set; }
        [Required(ErrorMessage = "Enter the contact.")]
        [StringLength(50,ErrorMessage="The Contact attribute be Between 1 and 50 characters.")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Enter the phone.")]
        [StringLength(12, ErrorMessage = "The phone must be between 1 and 50 characters.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Is the location active or not?")]
        public bool Active { get; set; }

        public virtual ICollection<PlacementContracts> PCList { get; set; }
        public virtual ICollection<Shifts> ShiftList { get; set; }
        public virtual ICollection<Employees> EmployeeList { get; set; }
        public virtual ICollection<Schedules> ScheduleList { get; set; }
        public virtual ICollection<Skills> SkillList { get; set; }


       
    }
}
