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
        }
    }
}
