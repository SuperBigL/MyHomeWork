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

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<POCOs.EmployeeSkillsMenuItem> GetReportESMenuItems()
        {
            using (WorkScheduleContext context = new WorkScheduleContext())
            {
                var results = from cat in context.Skills
                              orderby cat.Description
                              select new POCOs.EmployeeSkillsMenuItem
                              {
                                  SkillDescription = cat.Description,
                                  FullName = cat.EmployeeSkills.Employee.LastName + ", " + cat.EmployeeSkills.Employee.FirstName,
                                  Contact = cat.EmployeeSkills.Employee.HomePhone,
                                  YOE = Convert.ToInt32(cat.EmployeeSkills.YearsOfExperience)
                              };
                return results.ToList();
 
            }
        }




    }
}
