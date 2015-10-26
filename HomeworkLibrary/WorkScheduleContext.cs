using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkLibrary.Entities;
using System.Data.Entity;
using HomeworkLibrary.BAL.Entities;

namespace HomeworkLibrary.DAL
{
    public class WorkScheduleContext:DbContext
    {
        public WorkScheduleContext() : base("name=WS")
        {

        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PlacementContracts> PlacementContracts { get; set; }
        public DbSet<Shifts> Shifts { get; set; }
        public DbSet<Skills> Skills { get; set;}
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<EmployeeSkills> EmployeeSkills { get; set; }




    }
}
