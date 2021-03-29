using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class ContainsMethod
    {
        public static void GetDataByContainsOpr()
        {
            Console.WriteLine("\n Contains Method in C# is used to check whether a sequence or collection (i.e. data source) contains a specified element or not."+
                    "\n If the data source contains the specified element, then it returns true else return false. ");

            Console.WriteLine("Note:  IEqualityComparer method works in a different manner when working with complex type objects.\n"+
                "For complex type objects, it only checks the reference, not the values. In order to work with values, we need to use IEqualityComparer.");

            Console.WriteLine("The following example returns false even though the values that we passed is available in the data source."+
                "\n This is because the Linq Contains Method in C# does not check the values rather it checks the object reference and in this case,"+
                " the object references are different.");

            List<Student> students = new List<Student>()
                        {
                            new Student(){ID = 101, Name = "Priyanka", TotalMarks = 275 },
                            new Student(){ID = 102, Name = "Preety", TotalMarks = 375 }
                        };
            //Using Method Syntax
            var IsExistsMS = students.Contains(new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 });
            var student1 = new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 };
            //Using Query Syntax
            var IsExistsQS = (from num in students
                              select num).Contains(student1);

            Console.WriteLine(IsExistsMS);  //Output: False

            Console.WriteLine("----------IEqualityComparer---------");
            //Createing Student Comparer Instance
            StudentComparer studentComparer = new StudentComparer();
            //Using Method Syntax
            var IsExistsMS1 = students.Contains(new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 }, studentComparer);
            var student11 = new Student() { ID = 101, Name = "Priyanka", TotalMarks = 275 };
            //Using Query Syntax
            var IsExistsQS1 = (from num in students
                              select num).Contains(student1, studentComparer);
            Console.WriteLine(IsExistsMS1);
        }
    }
}
