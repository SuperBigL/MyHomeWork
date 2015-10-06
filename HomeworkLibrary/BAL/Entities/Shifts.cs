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
    public class Shifts
    {
        [Key]
        public int ShiftID { get; set; }
        public int PlacementContractID { get; set; }
        public int DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string Notes { get; set; }
    }
}
