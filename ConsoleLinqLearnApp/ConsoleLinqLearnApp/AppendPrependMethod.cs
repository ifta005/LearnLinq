using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class AppendPrependMethod
    {
        public static void GetAppendPrependMethod()
        {
            Console.WriteLine("\n >> Append << \n ");

            // Creating a list of integer
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);
            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));
            // Creating a new sequence explicitly
            List<int> newintSequence = intSequence.Append(5).ToList();
            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));


            Console.WriteLine("\n >> Prepend << \n ");
            // Creating a list of numbers
            List<int> numberSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to prepend 50
            numberSequence.Prepend(50);
            // It will not work because the original sequence has not been changed
            Console.WriteLine(string.Join(", ", numberSequence));
            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numberSequence.Prepend(50)));
            // If you prefer, you can create a new list explicitly
            List<int> newnumberSequence = numberSequence.Prepend(50).ToList();
            // And then write to the console output
            Console.WriteLine(string.Join(", ", newnumberSequence));


            Console.WriteLine("\n >> Zip method. << \n ");

            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }

        }
    }
}
