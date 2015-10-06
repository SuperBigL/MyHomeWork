using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HomeworkLibrary
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage="You Need a name") ]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public bool Active { get; set; }
    }
}
