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
    public class EmployeeSkills
    {
        [Key]
        public int EmployeeSkillID { get; set; }
        [Required(ErrorMessage="You must have an EmployeeID")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage="You must have a skillID")]
        public int SkillID { get; set; }
        [Required(ErrorMessage="You must have a Level")]
        public int Level { get; set; }
        public int YearsOfExperience { get; set; }

    }
}
