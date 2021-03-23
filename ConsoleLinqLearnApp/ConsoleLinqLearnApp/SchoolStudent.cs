using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class SchoolStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<SchoolStudent> GetStudents()
        {
            List<SchoolStudent> students = new List<SchoolStudent>()
            {
                new SchoolStudent {ID = 101, Name = "Preety" },
                new SchoolStudent {ID = 102, Name = "Sambit" },
                new SchoolStudent {ID = 103, Name = "Hina"},
                new SchoolStudent {ID = 104, Name = "Anurag"},
                new SchoolStudent {ID = 102, Name = "Sambit"},
                new SchoolStudent {ID = 103, Name = "Hina"},
                new SchoolStudent {ID = 101, Name = "Preety" },
            };
            return students;
        }

        public override bool Equals(object obj)
        {
            //As the obj parameter type id object, so we need to
            //cast it to Student Type
            return this.ID == ((SchoolStudent)obj).ID && this.Name == ((SchoolStudent)obj).Name;
        }

        public override int GetHashCode()
        {
            //Get the ID hash code value
            int IDHashCode = this.ID.GetHashCode();
            //Get the string HashCode Value
            //Check for null refernece exception
            int NameHashCode = this.Name == null ? 0 : this.Name.GetHashCode();
            return IDHashCode ^ NameHashCode;
        }

    }
}
