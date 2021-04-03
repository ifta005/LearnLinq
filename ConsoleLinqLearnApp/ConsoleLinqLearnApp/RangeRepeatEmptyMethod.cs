using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class RangeRepeatEmptyMethod
    {
        public static void GetRangeRepeatEmptyMethod()
        {
            Console.WriteLine("\n >> Select <<\n");
            IEnumerable<int> EvenNumbers = Enumerable.Range(1, 5).Select(x => x * x);
            foreach (int num in EvenNumbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("\n >> Repeat <<\n");
            IEnumerable<string> repeatStrings = Enumerable.Repeat(": Welcome to DOT NET :", 3);
            foreach (String str in repeatStrings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n >> Empty <<\n");
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();

            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);
            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);

            //IEnumerable<int> integerSequence = Student.GetStudents().Select(x => x.ID);
            //if (integerSequence != null)

            IEnumerable<int> integerSequence = Student.GetStudents().Select(x => x.ID) ?? Enumerable.Empty<int>(); ;
            foreach (var num in integerSequence)
            {
                Console.WriteLine(num);
            }
        }
    }
}
