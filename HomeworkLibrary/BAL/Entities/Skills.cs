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
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }
        [Required(ErrorMessage="You need a description"), Range(1, 100, ErrorMessage= "Description must be between 1 and 100 characters")]
        public string Description { get; set; }
        public bool RequiresTicket { get; set; }
        public int LocationID { get; set; }
    }
}
