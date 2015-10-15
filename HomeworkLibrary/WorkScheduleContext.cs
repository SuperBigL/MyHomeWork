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
        public WorkScheduleContext() : base("name=WorkSchedule")
        {

        }

        public DbSet<Employees> EmployeeList { get; set; }
        public DbSet<Location> LocationList { get; set; }
        public DbSet<PlacementContracts> PCList { get; set; }
        public DbSet<Shifts> ShiftList { get; set; }
        public DbSet<Skills> SkillList { get; set;}
        public DbSet<Schedules> ScheduleList { get; set; }




    }
}
