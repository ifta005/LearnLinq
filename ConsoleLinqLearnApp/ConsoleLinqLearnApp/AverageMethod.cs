using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class AverageMethod
    {
        public static void GetTotalValueBYFunc()
        {
            Console.WriteLine("\n****SUM***");
            //Using Method Syntax
            var TotalSalaryMS = Employee.GetAllEmployeesWithDept()
                              .Where(emp => emp.Department == "IT")
                              .Sum(emp => emp.Salary);
            //Using Query Syntax
            var TotalSalaryQS = (from emp in Employee.GetAllEmployeesWithDept()
                                 where emp.Department == "IT"
                                 select emp).Sum(e => e.Salary);

            Console.WriteLine("\n IT Department Total Salary = " + TotalSalaryQS);

            //Using Method Syntax and Predicate
            var TotalSalaryMS1 = Employee.GetAllEmployeesWithDept()
                              .Sum(emp => {
                                  if (emp.Department == "IT")
                                      return emp.Salary;
                                  else
                                      return 0;
                              });

            Console.WriteLine("\n IT Department Total Salary = " + TotalSalaryMS1);

            Console.WriteLine("\n****MAX***");
            //Using Method Syntax
            var MSHighestSalary2 = Employee.GetAllEmployeesWithDept()
                              .Where(emp => emp.Department == "IT")
                              .Max(emp => emp.Salary);
            //Using Query Syntax
            var QSHighestSalary2 = (from emp in Employee.GetAllEmployeesWithDept()
                                   where emp.Department == "IT"
                                   select emp).Max(e => e.Salary);
            Console.WriteLine("\n It Department Highest Salary = " + QSHighestSalary2);

            //Using Method Syntax
            var MSHighestSalary22 = Employee.GetAllEmployeesWithDept()
                              .Max(emp => {
                                  if (emp.Department == "IT")
                                      return emp.Salary;
                                  else
                                      return 0;
                              });
            Console.WriteLine("\n It Department Highest Salary = " + MSHighestSalary22);

            Console.WriteLine("\n****Average***");
            //Using Method Syntax
            var MSAverageSalary3 = Employee.GetAllEmployeesWithDept()
                                 .Where(emp => emp.Department == "IT")
                                 .Average(emp => emp.Salary);
            //Using Query Syntax
            var QSAverageSalary3 = (from emp in Employee.GetAllEmployeesWithDept()
                                   where emp.Department == "IT"
                                   select emp).Average(e => e.Salary);
            Console.WriteLine("IT Department Average Salary = " + MSAverageSalary3);
        }
       
    }
}
