using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class SelectOperator
    {
        public static void GetEmployeeInfo()
        {
            //Query Syntax
            IEnumerable<EmployeeBasicInfo> selectQuery = (from emp in Employee.GetEmployees()
                                                          select new EmployeeBasicInfo()
                                                          {
                                                              FirstName = emp.FirstName,
                                                              LastName = emp.LastName,
                                                              Salary = emp.Salary
                                                          });

            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }
            //Method Syntax
            List<EmployeeBasicInfo> selectMethod = Employee.GetEmployees().
                                          Select(emp => new EmployeeBasicInfo()
                                          {
                                              FirstName = emp.FirstName,
                                              LastName = emp.LastName,
                                              Salary = emp.Salary
                                          }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
            }


            Console.WriteLine("--INDEX POSITION --");

            //Query Syntax
            var query = (from emp in Employee.GetEmployees().Select((value, index) => new { value, index })
                         select new
                         {
                             IndexPosition = emp.index,
                             FullName = emp.value.FirstName + " " + emp.value.LastName,
                             Salary = emp.value.Salary
                         }).ToList();
            foreach (var emp in query)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }
            //Method Syntax
            var selectMethod1 = Employee.GetEmployees().
                                          Select((emp, index) => new
                                          {
                                              IndexPosition = index,
                                              FullName = emp.FirstName + " " + emp.LastName,
                                              Salary = emp.Salary
                                          });

            foreach (var emp in selectMethod1)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }
        }
    }
}
