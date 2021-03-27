using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class MethodUnion
    {
        public static void GetDataByUnion()
        {
            string[] dataSource1 = { "India", "USA", "UK", "Canada", "Srilanka" };
            string[] dataSource2 = { "India", "uk", "Canada", "France", "Japan" };

            //Method Syntax
            var MS = dataSource1.Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            //Query Syntax
            var QS = (from country in dataSource1
                      select country)
                      .Union(dataSource2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }


            //****************************
            List<SchoolStudent> StudentCollection1 = new List<SchoolStudent>()
            {
                new SchoolStudent {ID = 101, Name = "Preety" },
                new SchoolStudent {ID = 102, Name = "Sambit" },
                new SchoolStudent {ID = 105, Name = "Hina"},
                new SchoolStudent {ID = 106, Name = "Anurag"},
            };
            List<SchoolStudent> StudentCollection2 = new List<SchoolStudent>()
            {
                new SchoolStudent {ID = 105, Name = "Hina"},
                new SchoolStudent {ID = 106, Name = "Anurag"},
                new SchoolStudent {ID = 107, Name = "Pranaya"},
                new SchoolStudent {ID = 108, Name = "Santosh"},
            };
            //Method Syntax
            var MS1 = StudentCollection1.Select(x => new { x.ID, x.Name })
                     .Union(StudentCollection2.Select(x => new { x.ID, x.Name })).ToList();
            //Query Syntax
            var QS1 = (from std in StudentCollection1
                      select new { std.ID, std.Name })
                      .Union(StudentCollection2.Select(x => new { x.ID, x.Name })).ToList();

            foreach (var student in MS1)
            {
                Console.WriteLine($" ID : {student.ID} Name : {student.Name}");
            }

        }

    }
}
