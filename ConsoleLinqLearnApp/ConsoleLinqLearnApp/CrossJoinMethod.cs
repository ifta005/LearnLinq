using ConsoleLinqLearnApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class CrossJoinMethod
    {
        public static void GetCrossJoinMethod()
        {
            var CrossJoinResult = from employee in StudentModel2.GetAllStudnets()
                                  from subject in SubjectModel2.GetAllSubjects()
                                  select new
                                  {
                                      Name = employee.Name,
                                      SubjectName = subject.SubjectName
                                  };
            foreach (var item in CrossJoinResult)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }

            //Cross Join using SelectMany Method
            Console.WriteLine("\nCross Join using SelectMany Method");
            var CrossJoinResult3 = StudentModel2.GetAllStudnets()
                        .SelectMany(sub => SubjectModel2.GetAllSubjects(),
                         (std, sub) => new
                         {
                             Name = std.Name,
                             SubjectName = sub.SubjectName
                         });

            foreach (var item in CrossJoinResult3)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }
            //Cross Join using Join Method
            Console.WriteLine("\nCross Join using Join Method");
            var CrossJoinResult2 = StudentModel2.GetAllStudnets()
                        .Join(SubjectModel2.GetAllSubjects(),
                            std => true,
                            sub => true,
                            (std, sub) => new
                            {
                                Name = std.Name,
                                SubjectName = sub.SubjectName
                            }
                         );
            foreach (var item in CrossJoinResult2)
            {
                Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
            }
        }
    }
}
