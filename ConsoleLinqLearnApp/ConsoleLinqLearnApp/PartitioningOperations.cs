using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class PartitioningOperations
    {
        public static void GetPartitioningOperations()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int[] ResultMS = numbers.Where(num => num > 3).Take(4).ToArray();
            //Using Mixed Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Take(4).ToList();

            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");   //Output: 4 5 6 7
            }

            Console.WriteLine("\nIf you apply the Filtering Operator after the Take method then you will not get the result as expected \n");

            List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Using Method Syntax
            int[] ResultMS1 = numbers.Take(4).Where(num => num > 2).ToArray();
            //Using Mixed Syntax
            List<int> ResultQS1 = (from num in numbers
                                  select num).Take(4).Where(num => num > 2).ToList();

            foreach (var num in ResultQS1)
            {
                Console.Write($"{num} ");   //Output: 3 4
            }

            ///TakeWhile Method
            ///

            Console.WriteLine("\nWhen we are applying the Take operator on a data source which is null, then we will get an exception \n ");

            Console.WriteLine("\n >> TakeWhile Method << \n ");

            List<int> numbers2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> ResultMS2 = numbers.TakeWhile(num => num < 6).ToList();

            foreach (var num in ResultMS2)
            {
                Console.Write($"{num} ");
            }

            List<int> numbers3 = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };
            List<int> Result13 = numbers.TakeWhile(num => num < 6).ToList();
            Console.Write("Result Of TakeWhile Method: ");
            foreach (var num in Result13)
            {
                Console.Write($"{ num} ");      //TakeWhile” method fetches the values 1, 2, and 3
            }
            Console.WriteLine();

            //Using Where Method
            List<int> Result23 = numbers.Where(num => num < 6).ToList();
            Console.Write("Result Of Where Method: ");
            foreach (var num in Result23)
            {
                Console.Write($"{ num} ");      //Where” method fetches the values 1, 2, 3, 4, and 5.
            }

        }
    }
}
