using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class AggregateMethod
    {
        public static void GetValueBYSimpleMethod()
        {
            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = string.Empty;
            foreach (string skill in skills)
            {
                result = result + skill + ", ";
            }
            //Find the index position of last comma
            int lastIndex = result.LastIndexOf(",");
            //Remove the last comma
            result = result.Remove(lastIndex);
            Console.WriteLine(result);

            string result1 = skills.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine("\n" + result1);

            int[] intNumbers = { 3, 5, 7, 9 };
            int result2 = intNumbers.Aggregate((n1, n2) => n1 * n2);
            Console.WriteLine("\n" + result2);

            result2 = intNumbers.Aggregate(2, (n1, n2) => n1 * n2);
            Console.WriteLine("\n" + result2);
        }

        public static void GetValueBYForEmployee()
        {
            string CommaSeparatedEmployeeNames = Employee.GetAllEmployeesWithDept().Aggregate<Employee, string>(
                                        "Employee Names : ",  // seed value
                                        (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ", ");

            int LastIndex = CommaSeparatedEmployeeNames.LastIndexOf(",");
            CommaSeparatedEmployeeNames = CommaSeparatedEmployeeNames.Remove(LastIndex);
            Console.WriteLine("\n"+CommaSeparatedEmployeeNames);

            string CommaSeparatedEmployeeNames1 = Employee.GetAllEmployeesWithDept().Aggregate<Employee, string, string>(
                                       "Employee Names : ",  // seed value
                                       (employeeNames, employee) => employeeNames = employeeNames + employee.Name + ",",
                                       employeeNames => employeeNames.Substring(0, employeeNames.Length - 1));

            Console.WriteLine("\n" + CommaSeparatedEmployeeNames1);
        }
    }
}
