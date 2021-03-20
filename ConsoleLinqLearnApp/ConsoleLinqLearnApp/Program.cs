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
            Console.WriteLine("[1]SELECT LINQ: ");

            Console.Write("[Enter]: ");
            idea = Convert.ToInt32(Console.ReadLine());
            switch (idea)
            {
                case 1:
                    Console.WriteLine("SELECT LINQ");
                    SelectOperator.GetEmployeeInfo();
                    break;
            }
                    SelectOperator.GetEmployeeInfo();
            Console.ReadKey();
        }
    }
}
