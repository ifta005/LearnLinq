using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class CommonMethod
    {
        public static void GetVoidData()
        {
            Console.WriteLine("\n >>SequenceEqual<< \n");

            List<string> cityList1 = new List<string> { "DELHI", "mumbai", "Hyderabad" };
            List<string> cityList2 = new List<string> { "delhi", "MUMBAI", "Hyderabad" };
            bool IsEqual = cityList1.SequenceEqual(cityList2, StringComparer.OrdinalIgnoreCase); //case-insensitive

            Console.WriteLine(IsEqual);

            bool IsEqual1 = cityList1.OrderBy(city => city)
                   .SequenceEqual(cityList2.OrderBy(city => city), StringComparer.OrdinalIgnoreCase);
            Console.WriteLine(IsEqual1);


        }
    }
}
