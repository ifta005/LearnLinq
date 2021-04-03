using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class OfTypeMethod
    {
        public static void GetOfTypeMethod()
        {
            try
            {
                Console.WriteLine("\n >> OFTYPE  << \n ");

                ArrayList list = new ArrayList
            {
                10,
                20,
                30,
                "50"
            };

                IEnumerable<int> result = list.OfType<int>();
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }

                //Output: 10 20 30
                //Now, when you run the application, you will not get any exception.
                //The value “50” is ignored as well as excluded from the result.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
