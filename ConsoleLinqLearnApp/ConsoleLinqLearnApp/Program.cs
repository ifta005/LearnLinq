using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLinqLearnApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int caseSwitch = 0;
            Console.WriteLine("[1]SELECT : ");
            Console.WriteLine("[2]SELECT Many : ");
            Console.WriteLine("[3]SELECT Where : ");
            Console.WriteLine("[4]SELECT Where : ");
            Console.WriteLine("[5]Of Type : ");
            Console.WriteLine("[6]Distinct : ");
            Console.WriteLine("[7]Distinct_2 : ");

            Console.WriteLine("\n[0]EXIT : ");

            Console.Write("[Enter No]: ");
            caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    SelectOperator.GetEmployeeInfo();
                    break;
                case 2:
                    Console.WriteLine("**************");
                    SelectManyOperator.GetStudentInfo();
                    Console.WriteLine("**************");
                    break;
                case 3:
                    Console.WriteLine("**************");
                    Predicate.GetOddValueWithIndex();
                    Console.WriteLine("**************");
                    break;
                case 4:
                    Console.WriteLine("**************");
                    Predicate.GetEmpInfoWithSalary();
                    Console.WriteLine("**************");
                    break;
                case 5:
                    Console.WriteLine("**************");
                    OfTypeOperator.GetValue();
                    Console.WriteLine("**************");
                    break;
                case 6:
                    Console.WriteLine("**************");
                    DistinctOperator.GetDistinctStudent();
                    Console.WriteLine("**************");
                    break;
                case 7:
                    Console.WriteLine("**************");
                    StudentComparerDemo.GetStudentWithDistinctValue();
                    Console.WriteLine("**************");
                    break;
                default:
                    Environment.Exit(0);// exit
                    break;
            }
            Environment.Exit(1);// exit
        }
    }
}
