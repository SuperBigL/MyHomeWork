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
    public class Shifts
    {
        [Key]
        public int ShiftID { get; set; }
        [Required(ErrorMessage="You need a Placement contract ID")]
        public int PlacementContractID { get; set; }
        [Required(ErrorMessage="Enter a day of the week")]
        public int DayOfWeek { get; set; }
        [Required(ErrorMessage="You need a start time")]
        public DateTime StartTime { get; set; }
         [Required(ErrorMessage = "You need an end time")]
        public DateTime EndTime { get; set; }
         [Required(ErrorMessage = "You need a number of employees")]
        public int NumberOfEmployees { get; set; }
        [Required(ErrorMessage="You need to tell the system if it's active.")]
        public bool Active { get; set; }
        public string Notes { get; set; }


        
        public virtual PlacementContracts PlacementContracts { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }

    }
}
