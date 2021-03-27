using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class QuantifiersOperatorALL
    {
        public static void GetDataByALL()
        {

            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            var Result1 = stringArray.All(name => name.Length > 5);
            Console.WriteLine("Is All Names are greater than 5 Characters : " + Result1);

            //Using Method Syntax
            bool MSResult = Student.GetAllStudnetsWithSubject().All(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSResult = (from std in Student.GetAllStudnetsWithSubject()
                             select std).All(std => std.TotalMarks > 250);
            Console.WriteLine(MSResult);

            //Using Method Syntax
            var MSResult1 = Student.GetAllStudnetsWithSubject()
                            .Where(std => std.Subjects.All(x => x.Marks > 80)).ToList();

            //Using Query Syntax
            var QSResult1 = (from std in Student.GetAllStudnetsWithSubject()
                            where std.Subjects.All(x => x.Marks > 80)
                            select std).ToList();
            foreach (var item in QSResult1)
            {
                Console.WriteLine(item.Name + " " + item.TotalMarks);
            }

        }
    }
}
