using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLinqLearnApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int idea;
            Console.WriteLine("[1]SELECT : ");
            Console.WriteLine("[2]SELECT Many : ");

            Console.Write("[Enter]: ");
            idea = Convert.ToInt32(Console.ReadLine());
            switch (idea)
            {
                case 1:
                    SelectOperator.GetEmployeeInfo();
                    break;
                case 2:
                    Console.WriteLine("**************");
                    SelectManyOperator.GetStudentInfo();
                    Console.WriteLine("**************");
                    break;
            }                    
            Console.ReadKey();
        }
    }
}
