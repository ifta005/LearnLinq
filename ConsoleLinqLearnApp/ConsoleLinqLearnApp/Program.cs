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
            Console.WriteLine("[8]Except : ");
            Console.WriteLine("[9]Intersect : ");
            Console.WriteLine("[10]Union : ");
            Console.WriteLine("[11]Reverse : ");
            Console.WriteLine("[12]Average : ");
            Console.WriteLine("[13]Aggregate : ");
            Console.WriteLine("[14]ALL Operator : ");
            Console.WriteLine("[15]ANY : ");
            Console.WriteLine("[16]Contain : ");
            Console.WriteLine("[17]Group BY : ");
            Console.WriteLine("[18]Group BY Multiple: ");
            Console.WriteLine("[19]JOIN Multiple Data: ");
            Console.WriteLine("[20]Left Outer Join: ");
            Console.WriteLine("[21]Cross Join: ");
            Console.WriteLine("[22]Method: ");
            Console.WriteLine("[23]Cross Join: ");
            Console.WriteLine("[24]Skip Method: ");
            Console.WriteLine("[25]PAGINATION: ");
            Console.WriteLine("[25]Range Repeat Empty Method: ");

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
                case 8:
                    Console.WriteLine("******Except********");
                    MethodExcept.GetInfoExceptList();
                    Console.WriteLine("**************");
                    break;
                case 9:
                    Console.WriteLine("\n******Intersect********");
                    MethodIntersect.GetDataByIntersect();
                    Console.WriteLine("\n**************");
                    break;
                case 10:
                    Console.WriteLine("\n******UNION********");
                    MethodUnion.GetDataByUnion();
                    Console.WriteLine("\n**************");
                    break;
                case 11:
                    Console.WriteLine("\n******Reverse********");
                    ReverseMethod.GetReverseData();
                    Console.WriteLine("\n**************");
                    break;
                case 12:
                    Console.WriteLine("\n******Average********");
                    AverageMethod.GetTotalValueBYFunc();
                    Console.WriteLine("\n**************");
                    break;
                case 13:
                    Console.WriteLine("\n******Aggregate********");
                    AggregateMethod.GetValueBYSimpleMethod();
                    Console.WriteLine("\n**************");
                    Console.WriteLine("\n******Aggregate********");
                    AggregateMethod.GetValueBYForEmployee();
                    Console.WriteLine("\n**************");
                    break;
                case 14:
                    Console.WriteLine("\n******Average********");
                    QuantifiersOperatorALL.GetDataByALL();
                    Console.WriteLine("\n**************");
                    break;
                case 15:
                    Console.WriteLine("\n******ANY********");
                    QuantifiersOperatorAny.GetDataByAnyOpr();
                    Console.WriteLine("\n**************");
                    break;
                case 16:
                    Console.WriteLine("\n******Contains********");
                    ContainsMethod.GetDataByContainsOpr();
                    Console.WriteLine("\n**************");
                    break;
                case 17:
                    Console.WriteLine("\n******Group BY********");
                    GroupByMethod.GetDataByGroup();
                    Console.WriteLine("\n**************");
                    break;
                case 18:
                    Console.WriteLine("\n******Multiple Group BY********");
                    GroupByMultipleMethod.GetMultipleDataByGroup();
                    Console.WriteLine("\n**************");
                    break;
                case 19:
                    Console.WriteLine("\n******JOIN Multiple DATA ********");
                    JoinMultipleData.GetMultipleJoinData();
                    Console.WriteLine("\n**************");
                    break;
                case 20:
                    Console.WriteLine("\n******Left Outer JOIN DATA ********");
                    LeftOuterJoinMethod.GetLeftOuterJoinMethod();
                    Console.WriteLine("\n**************");
                    break;
                case 21:
                    Console.WriteLine("\n******Cross Join ********");
                    CrossJoinMethod.GetCrossJoinMethod();
                    Console.WriteLine("\n**************");
                    break;

                case 22:
                    Console.WriteLine("\n****** Common ********");
                    CommonMethod.GetVoidData();
                    Console.WriteLine("\n**************");
                    break;
                case 23:
                    Console.WriteLine("\n******Partitioning Operation********");
                    PartitioningOperations.GetPartitioningOperations();
                    Console.WriteLine("\n**************");
                    break;
                case 24:
                    Console.WriteLine("\n******Skip Method********");
                    SkipMethod.GetSkipMethod();
                    Console.WriteLine("\n**************");
                    break;
                case 25:
                    Console.WriteLine("\n******PAGE********");
                    PageWithTakeSkipMethod.GetPageWithTakeSkipMethod();
                    Console.WriteLine("\n**************");
                    break;
                case 26:
                    Console.WriteLine("\n******Range Repeat Empty ********");
                    RangeRepeatEmptyMethod.GetRangeRepeatEmptyMethod();
                    Console.WriteLine("\n**************");
                    break;
                default:
                    Environment.Exit(0);// exit
                    break;
            }
            Environment.Exit(1);// exit
        }
    }
}
