using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class Predicate
    {
        public static void GetOddValueWithIndex()
        {
            Console.WriteLine("A predicate is nothing but a function that is used to test each and every element for a given condition. ");

            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            var OddNumbersWithIndexPosition = intList.Select((num, Index) => new
            {
                numbers = num,
                indexPosition = Index
            }).Where(x => x.numbers % 2 != 0).Select(data => new
            {
                Number = data.numbers,
                IndexPosition = data.indexPosition
            });

            foreach (var item in OddNumbersWithIndexPosition)
            {
                Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
            }


            //Query Syntax
            Console.WriteLine("*****Query Syntax******");
            var OddNumbersWithIndexPosition1 = from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
                                               where number.Numbers % 2 != 0
                                               select new
                                               {
                                                   Number = number.Numbers,
                                                   IndexPosition = number.IndexPosition
                                               };

            foreach (var item in OddNumbersWithIndexPosition1)
            {
                Console.WriteLine($"IndexPosition :{item.IndexPosition} , Value : {item.Number}");
            }
        }
        public static void GetEmpInfoWithSalary()
        {
            //Query Syntax
            var QuerySyntax = (from data in Employee.GetEmployeesWithTech().Select((Data, index) => new { employee = Data, Index = index })
                               where data.employee.Salary >= 500000 && data.employee.Gender == "Male"
                               select new
                               {
                                   EmployeeName = data.employee.Name,
                                   Gender = data.employee.Gender,
                                   Salary = data.employee.Salary,
                                   IndexPosition = data.Index
                               }).ToList();
            //Method Syntax
            var MethodSyntax = Employee.GetEmployeesWithTech().Select((Data, index) => new { employee = Data, Index = index })
                               .Where(emp => emp.employee.Salary >= 500000 && emp.employee.Gender == "Male")
                               .Select(emp => new
                               {
                                   EmployeeName = emp.employee.Name,
                                   Gender = emp.employee.Gender,
                                   Salary = emp.employee.Salary,
                                   IndexPosition = emp.Index
                               })
                               .ToList();
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine($"Position : {emp.IndexPosition} Name : {emp.EmployeeName}, Gender : {emp.Gender}, Salary : {emp.Salary}");
            }
        }

    }
}
