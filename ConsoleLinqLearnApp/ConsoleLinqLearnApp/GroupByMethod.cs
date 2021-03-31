using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleLinqLearnApp
{
    public class GroupByMethod
    {
        public static void GetDataByGroup()
        {
            //Using Method Syntax
            var GroupByMS = Student.GetStudentsWithBranch().GroupBy(s => s.Barnch);

            //Using Query Syntax
            IEnumerable<IGrouping<string, Student>> GroupByQS = ( from std in Student.GetStudentsWithBranch()   
                                                                  group std by std.Barnch);

            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }



            //Using Method Syntax
            var GroupByMS1 = Student.GetStudentsWithBranch().GroupBy(s => s.Gender)
                            //First sorting the data based on key in Descending Order
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                //Sorting the data based on name in descending order
                                Students = std.OrderBy(x => x.Name)
                            });
            //Using Query Syntax
            var GroupByQS1 = from std in Student.GetStudentsWithBranch()
                            group std by std.Gender into stdGroup
                            orderby stdGroup.Key descending
                            select new
                            {
                                Key = stdGroup.Key,
                                Students = stdGroup.OrderBy(x => x.Name)
                            };
            //It will iterate through each groups
            foreach (var group in GroupByQS1)
            {
                Console.WriteLine(group.Key + " : " + group.Students.Count());
                //Iterate through each student of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Branch :" + student.Barnch);
                }
            }

        }
    }
}
