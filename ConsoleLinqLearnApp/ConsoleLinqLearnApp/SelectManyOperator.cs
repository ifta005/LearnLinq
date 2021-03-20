using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class SelectManyOperator
    {
        public static void GetStudentInfo()
        {
           
            //Using Method Syntax
            List<string> MethodSyntax = Student.GetStudents()
                                        .SelectMany(std => std.Programming)
                                        .Distinct()
                                        .ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = (from std in Student.GetStudents()
                                               from program in std.Programming
                                               select program).Distinct().ToList();

            //Printing the values
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("retrieve the student name along with the program language name");
            //Using Method Syntax
            var MethodSyntax2 = Student.GetStudents()
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }
                                             )
                                        .ToList();

            foreach (var item in MethodSyntax2)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }

            //Using Query Syntax
            Console.WriteLine("Using Query Syntax");
            var QuerySyntax2 = (from std in Student.GetStudents()
                                from program in std.Programming
                                select new
                                {
                                    StudentName = std.Name,
                                    Programming = program
                                }).ToList();
            foreach (var item in QuerySyntax2)
            {
                Console.WriteLine(item.StudentName + " => " + item.Programming);
            }
        }
    }
}
