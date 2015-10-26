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

       public virtual Location Location { get; set; }
       public virtual ICollection<Schedules> Schedules { get; set; }
    }
}
