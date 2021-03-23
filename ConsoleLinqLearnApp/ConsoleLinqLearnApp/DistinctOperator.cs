using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class DistinctOperator
    {
        public static void GetDistinctStudent()
        {
            Console.WriteLine("**Distinct**");
            //Using Method Syntax
            var MS = Student.GetSchoolStudents()
                    .Select(std => std.Name)
                    .Distinct().ToList();
            //Using Query Syntax
            var QS = (from std in Student.GetSchoolStudents()
                      select std.Name)
                      .Distinct().ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**Distinct Not working**");
            //Using Method Syntax
            var MS1 = Student.GetSchoolStudents()
                    .Distinct().ToList();
            //Using Query Syntax
            var QS1 = (from std in Student.GetSchoolStudents()
                      select std)
                      .Distinct().ToList();
            foreach (var item in QS1)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }

            Console.WriteLine("\n It will not select distinct students rather it select all the students. "+"\nThis is because the default comparer which is used for comparison is only checked \n whether two object references are equal and not the individual property values of the complex object.");


            //Creating an instance of StudentComparer
            StudentComparer studentComparer = new StudentComparer();
            //Using Method Syntax
            var MS3 = Student.GetSchoolStudents()
                    .Distinct(studentComparer).ToList();
            //Using Query Syntax
            var QS3 = (from std in Student.GetSchoolStudents()
                      select std)
                      .Distinct(studentComparer).ToList();
            foreach (var item in QS3)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }

        }
    }
}
