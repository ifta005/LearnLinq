using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class QuantifiersOperatorAny
    {
        public static void GetDataByAnyOpr()
        {
            Console.WriteLine("Any Operator is used to check whether at least one of the elements of a data source satisfies a given condition or not."+
                "\n If any of the elements satisfy the given condition, then it returns true else return false.");

            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Method Syntax
            var ResultMS = stringArray.Any(name => name.Length > 5);
            //Query Syntax
            var ResultQS = (from name in stringArray
                            select name).Any(name => name.Length > 5);
            Console.WriteLine("\n Is Any name with length  greater than 5 Characters : " + ResultMS);


            //Using Method Syntax
            bool MSResult = Student.GetAllStudnetsWithSubject().Any(std => std.TotalMarks > 250);
            //Using Query Syntax
            bool QSResult = (from std in Student.GetAllStudnetsWithSubject()
                             select std).Any(std => std.TotalMarks > 250);

            Console.WriteLine(MSResult);

            Console.WriteLine("\n ------------------ \n");
            //Using Method Syntax
            var MSResult1 = Student.GetAllStudnetsWithSubject()
                            .Where(std => std.Subjects.Any(x => x.Marks > 90)).ToList();
            //Using Query Syntax
            var QSResult1 = (from std in Student.GetAllStudnetsWithSubject()
                            where std.Subjects.Any(x => x.Marks > 90)
                            select std).ToList();
            foreach (var item in QSResult1)
            {
                Console.WriteLine(item.Name + " " + item.TotalMarks);
            }


        }
    }
}
