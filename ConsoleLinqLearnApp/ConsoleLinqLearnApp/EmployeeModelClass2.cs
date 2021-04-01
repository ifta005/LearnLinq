using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class EmployeeModelClass2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<EmployeeModelClass2> GetAllEmployees()
        {
            return new List<EmployeeModelClass2>()
            {
                new EmployeeModelClass2 { ID = 1, Name = "Preety", AddressId = 1},
                new EmployeeModelClass2 { ID = 2, Name = "Priyanka", AddressId =2},
                new EmployeeModelClass2 { ID = 3, Name = "Anurag", AddressId = 0},
                new EmployeeModelClass2 { ID = 4, Name = "Pranaya", AddressId = 0},
                new EmployeeModelClass2 { ID = 5, Name = "Hina", AddressId = 5},
                new EmployeeModelClass2 { ID = 6, Name = "Sambit", AddressId = 6}
            };
        }
    }
    public class AddressModel2
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<AddressModel2> GetAddress()
        {
            return new List<AddressModel2>()
            {
                new AddressModel2 { ID = 1, AddressLine = "AddressLine1"},
                new AddressModel2 { ID = 2, AddressLine = "AddressLine2"},
                new AddressModel2 { ID = 5, AddressLine = "AddressLine5"},
                new AddressModel2 { ID = 6, AddressLine = "AddressLine6"},
            };
        }
    }
}

