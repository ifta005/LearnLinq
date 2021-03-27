using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class MethodExcept
    {
        public static void GetInfoExceptList()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Except(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n**************COMPLEX*TYPE*************************");

            List<SchoolStudent> AllStudents = new List<SchoolStudent>()
            {
                new SchoolStudent {ID = 101, Name = "Preety" },
                new SchoolStudent {ID = 102, Name = "Sambit" },
                new SchoolStudent {ID = 103, Name = "Hina"},
                new SchoolStudent {ID = 104, Name = "Anurag"},
                new SchoolStudent {ID = 105, Name = "Pranaya"},
                new SchoolStudent {ID = 106, Name = "Santosh"},
            };
            List<SchoolStudent> Class6Students = new List<SchoolStudent>()
            {
                new SchoolStudent {ID = 102, Name = "Sambit" },
                new SchoolStudent {ID = 104, Name = "Anurag"},
                new SchoolStudent {ID = 105, Name = "Pranaya"},
            };

            //Method Syntax
            var MS1 = AllStudents.Except(Class6Students).ToList();
            //Query Syntax
            var QS1 = (from std in AllStudents
                      select std).Except(Class6Students).ToList();

            foreach (var student in MS1)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }

        }
    }
}
