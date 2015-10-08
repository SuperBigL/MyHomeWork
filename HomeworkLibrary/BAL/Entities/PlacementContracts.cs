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
   public class PlacementContracts
    {
       [Key]
       public int PlacementContractID { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
       public int LocationID { get; set; }


       public PlacementContracts()
       {
           StartDate = DateTime.Now;
           EndDate = DateTime.Now;
       }
    }
}
