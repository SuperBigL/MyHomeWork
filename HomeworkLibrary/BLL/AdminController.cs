using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using HomeworkLibrary.Entities;
using HomeworkLibrary.DAL;
using HomeworkLibrary.BAL;
using HomeworkLibrary.BLL;
using HomeworkLibrary.BAL.Entities;



namespace HomeworkLibrary.BLL
{
    [DataObject]
    public class AdminController
    {


        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Employees> EmployeeList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.Employees
                              orderby item.EmployeeID
                              select item;
                return results.ToList();


            }


        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Location> LocationList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.Locations
                              orderby item.LocationID
                              select item;
                return results.ToList();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Skills> SkillList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.Skills
                              orderby item.SkillID
                              select item;
                return results.ToList();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<PlacementContracts> PCList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.PlacementContracts
                              orderby item.PlacementContractID
                              select item;
                return results.ToList();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Schedules> ScheduleList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.Schedules
                              orderby item.ScheduleID
                              select item;
                return results.ToList();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Shifts> ShiftList()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from item in context.Shifts
                              orderby item.ShiftID
                              select item;
                return results.ToList();
            }

        }


        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void Location_Add (Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                Location added = null;

                added = context.Locations.Add(item);

                context.SaveChanges();

            }
        }


        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void Location_Update(Location item)
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                context.Entry<Location>(context.Locations.Attach(item)).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<POCOs.EmployeeSkillsMenuItem> GetReportESMenuItems()
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                var results = from cat in context.EmployeeSkills
                              orderby cat.Skills.Description
                              select new POCOs.EmployeeSkillsMenuItem
                              {
                                  SkillDescription = cat.Skills.Description,
                                  FullName = cat.Employee.LastName + ", " + cat.Employee.FirstName,
                                  Phone = cat.Employee.HomePhone,
                                  Level = cat.Level.ToString(),
                                  YOE = Convert.ToInt32(cat.YearsOfExperience)
                              };
                return results.ToList();
 

            }
        }

        




    }
}
