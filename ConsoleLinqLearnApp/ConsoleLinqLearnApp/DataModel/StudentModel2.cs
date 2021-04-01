using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLinqLearnApp.DataModel
{
    public class StudentModel2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<StudentModel2> GetAllStudnets()
        {
            return new List<StudentModel2>()
            {
                new StudentModel2 { ID = 1, Name = "Preety"},
                new StudentModel2 { ID = 2, Name = "Priyanka"},
                new StudentModel2 { ID = 3, Name = "Anurag"},
                new StudentModel2 { ID = 4, Name = "Pranaya"},
                new StudentModel2 { ID = 5, Name = "Hina"}
            };
        }
    }

    public class SubjectModel2
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public static List<SubjectModel2> GetAllSubjects()
        {
            return new List<SubjectModel2>()
            {
                new SubjectModel2 { ID = 1, SubjectName = "ASP.NET"},
                new SubjectModel2 { ID = 2, SubjectName = "SQL Server" },
                new SubjectModel2 { ID = 5, SubjectName = "Linq"}
            };
        }
    }
}
