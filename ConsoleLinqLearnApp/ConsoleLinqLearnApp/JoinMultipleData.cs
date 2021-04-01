using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class JoinMultipleData
    {
        public static void GetMultipleJoinData()
        {
            var JoinMultipleDSUsingMS =
                            //Employee data Source (i.e. Data Source 1)
                            PadmaEmployee.GetAllEmployees()
                            //Joining with Address data Source (i.e. Data Source 2)
                            .Join(
                                    Address.GetAllAddresses(), //Inner Data Source 1
                                    empLevel1 => empLevel1.AddressId, //Outer Key selector  
                                    addLevel1 => addLevel1.ID, //Inner Key selector
                                                               //Result set
                                    (empLevel1, addLevel1) => new { empLevel1, addLevel1 }
                                )
                            // Joinging with Department data Source (i.e. data Source 3)
                            .Join(
                                    Department.GetAllDepartments(), //Inner Data Source 2
                                                                    //You cannot access the outer key selector directly
                                                                    //You can only access with the result set created in previous step
                                                                    //i.e. using empLevel1 and addLevel1
                                    empLevel2 => empLevel2.empLevel1.ID, //Outer Key selector
                                    addLevel1 => addLevel1.ID, //Inner Key selector
                                                               //Result set
                                    (empLevel2, addLevel1) => new { empLevel2, addLevel1 }
                            )
                            //Creating the actual result set
                            .Select(e => new
                            {
                                ID = e.empLevel2.empLevel1.ID,
                                EmployeeName = e.empLevel2.empLevel1.Name,
                                AddressLine = e.empLevel2.addLevel1.AddressLine,
                                DepartmentName = e.addLevel1.Name
                            }).ToList();
            foreach (var employee in JoinMultipleDSUsingMS)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.EmployeeName}, Department = {employee.DepartmentName}, Addres = {employee.AddressLine}");
            }
        }
    }
}
