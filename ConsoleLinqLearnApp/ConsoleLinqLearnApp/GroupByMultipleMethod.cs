using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class GroupByMultipleMethod
    {
        public static void GetMultipleDataByGroup()
        {
            //Using Method Syntax
            var GroupByMultipleKeysMS = Student.GetStudentsWithBranch()
                                        .GroupBy(x => new { x.Barnch, x.Gender })
                                        .OrderByDescending(g => g.Key.Barnch).ThenBy(g => g.Key.Gender)
                                        .Select(g => new
                                        {
                                            Branch = g.Key.Barnch,
                                            Gender = g.Key.Gender,
                                            Students = g.OrderBy(x => x.Name)
                                        });
            //Using Query Syntax
            var GroupByMultipleKeysQS = from student in Student.GetStudentsWithBranch()
                                        group student by new
                                        {
                                            student.Barnch,
                                            student.Gender
                                        } into stdGroup
                                        orderby stdGroup.Key.Barnch descending,
                                                stdGroup.Key.Gender ascending
                                        select new
                                        {
                                            Branch = stdGroup.Key.Barnch,
                                            Gender = stdGroup.Key.Gender,
                                            Students = stdGroup.OrderBy(x => x.Name)
                                        };
            //It will iterate through each group
            foreach (var group in GroupByMultipleKeysQS)
            {
                Console.WriteLine($"Barnch : {group.Branch} Gender: {group.Gender} No of Students = {group.Students.Count()}");
                //It will iterate through each item of a group
                foreach (var student in group.Students)
                {
                    Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.Age} ");
                }
                Console.WriteLine();
            }
        }
    }
}
