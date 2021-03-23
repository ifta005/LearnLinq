using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class StudentComparerDemo
    {
        public static void GetStudentWithDistinctValue()
        {
            //Using Method Syntax
            var MS = SchoolStudent.GetStudents()
                    .Distinct().ToList();
            //Using Query Syntax
            var QS = (from std in SchoolStudent.GetStudents()
                      select std)
                      .Distinct().ToList();
            foreach (var item in MS)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }

            Console.WriteLine("*******Anonymous Type*************");

            //Using Method Syntax
            var MS1 = SchoolStudent.GetStudents()
                    .Select(std => new { std.ID, std.Name })
                    .Distinct().ToList();
            //Using Query Syntax
            var QS1 = (from std in SchoolStudent.GetStudents()
                      select std)
                      .Select(std => new { std.ID, std.Name })
                      .Distinct().ToList();
            foreach (var item in MS1)
            {
                Console.WriteLine($"ID : {item.ID} , Name : {item.Name} ");
            }
        }
    }
}
