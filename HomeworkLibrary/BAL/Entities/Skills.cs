using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary.BAL.Entities
{
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }
        public string Description { get; set; }
        public string RequiresTicket { get; set; }
    }
}
