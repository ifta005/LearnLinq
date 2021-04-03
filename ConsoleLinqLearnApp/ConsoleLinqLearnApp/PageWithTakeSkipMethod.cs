using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class PageWithTakeSkipMethod
    {
        public static void GetPageWithTakeSkipMethod()
        {
            int RecordsPerPage = 4;
            int PageNumber = 0;
            do
            {
                /// Page Number = PN and Number Of Records Per Page = NRP, then you need to use the following formula:
                ///Result = DataSource.Skip((PN – 1) * NRP).Take(NRP)
                
                Console.WriteLine("Enter the Page Number between 1 and 4");
                if (int.TryParse(Console.ReadLine(), out PageNumber))
                {
                    if (PageNumber > 0 && PageNumber < 5)
                    {
                        var employees = Employee.GetAllEmployeesWithDept()
                                    .Skip((PageNumber - 1) * RecordsPerPage)
                                    .Take(RecordsPerPage).ToList();

                        Console.WriteLine();
                        Console.WriteLine("Page Number : " + PageNumber);
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Department : {emp.Department}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a Valid Page Number");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Page Number");
                }
            } while (PageNumber>0);
        }
    }
}
