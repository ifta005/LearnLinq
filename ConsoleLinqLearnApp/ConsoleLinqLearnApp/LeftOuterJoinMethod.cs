using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class LeftOuterJoinMethod
    {
        public static void GetLeftOuterJoinMethod()
        {
            var QSOuterJoin = from emp in EmployeeModelClass2.GetAllEmployees()
                              join add in AddressModel2.GetAddress() on emp.AddressId equals add.ID into EmployeeAddressGroup
                              from address in EmployeeAddressGroup.DefaultIfEmpty()
                              select new { emp, address };

            foreach (var item in QSOuterJoin)
            {
                Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
            }

            //Method Syntext
            Console.WriteLine("\n Method Syntext \n");
            var MSOuterJOIN = EmployeeModelClass2.GetAllEmployees()
                              .GroupJoin(
                                    AddressModel2.GetAddress(),
                                    emp => emp.AddressId,
                                    add => add.ID,
                                    (emp, add) => new { emp, add }
                              )
                              .SelectMany(
                                    x => x.add.DefaultIfEmpty(),
                                    (employee, address) => new { employee, address }
                               );
            foreach (var item in MSOuterJOIN)
            {
                Console.WriteLine($"Name : {item.employee.emp.Name}, Address : {item.address?.AddressLine} ");
            }

            Console.WriteLine("\n Anonymous type with user-defined properties in the ResultSet:");
            //Using Method Syntax
            var MSOuterJOIN1 = EmployeeModelClass2.GetAllEmployees()
                              .GroupJoin(
                                    AddressModel2.GetAddress(),
                                    emp => emp.AddressId,
                                    add => add.ID,
                                    (emp, add) => new { emp, add }
                              )
                              .SelectMany(
                                    x => x.add.DefaultIfEmpty(),
                                    (employee, address) => new
                                    {
                                        EmployeeName = employee.emp.Name,
                                        AddressLine = address == null ? "NA" : address.AddressLine
                                    }
                               );
            //Using Query Syntax
            var QSOuterJoin1 = from emp in EmployeeModelClass2.GetAllEmployees()
                               join add in AddressModel2.GetAddress() on emp.AddressId equals add.ID into EmployeeAddressGroup
                               from address in EmployeeAddressGroup.DefaultIfEmpty()
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address == null ? "NA" : address.AddressLine
                               };
            foreach (var item in MSOuterJOIN1)
            {
                Console.WriteLine($"Name : {item.EmployeeName}, Address : {item.AddressLine} ");
            }
        }
    }
}
