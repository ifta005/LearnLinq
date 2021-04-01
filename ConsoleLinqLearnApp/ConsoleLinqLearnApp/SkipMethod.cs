using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class SkipMethod
    {
        public static void GetSkipMethod()
        {
            //The Skip Method in Linq is used to skip or bypass the first “n” number of elements from a data source or sequence 
            //and then returns the remaining elements from the data source as output.

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Using Method Syntax
            int[] ResultMS = numbers.Where(num => num > 3).Skip(4).ToArray();

            //Using Mixed Syntax
            List<int> ResultQS = (from num in numbers
                                  where num > 3
                                  select num).Skip(4).ToList();
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");           //Output: 8 9 10
            }

            Console.WriteLine("\n When we are applying the Skip Method on a data source which is null, then we will get an exception i.e. ArgumentNullException");
            Console.WriteLine();

            Console.WriteLine("\n SkipWhile Method in Linq");

            List<int> numbers4 = new List<int>() { 1, 4, 5, 6, 7, 8, 9, 10, 2, 3 };
            List<int> ResultMS4 = numbers.SkipWhile(num => num < 5).ToList();
            foreach (var num in ResultMS4)
            {
                Console.Write($"{num} ");               //Output: 5 6 7 8 9 10 2 3
            }


        }
    }
}
