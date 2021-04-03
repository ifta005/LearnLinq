using ConsoleLinqLearnApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLinqLearnApp
{
    public class ToDictionaryMethod
    {
        public static void GetToDictionaryMethod()
        {
            try
            {
                Console.WriteLine("\n >> ToDictionary  << \n ");

                List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };


                Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.ID);
                foreach (KeyValuePair<int, Product> kvp in productsDictionary)
                {
                    Console.WriteLine(kvp.Key + " Name : " + kvp.Value.Name + ", Price: " + kvp.Value.Price);
                }

                //Overloaded version
                Console.WriteLine("\n >> ToDictionary Overload << \n ");
                Dictionary<int, string> productsDictionary1 = listProducts.ToDictionary(x => x.ID, x => x.Name);
                foreach (KeyValuePair<int, string> kvp in productsDictionary1)
                {
                    Console.WriteLine("Key : " + kvp.Key + " Value : " + kvp.Value);
                }

                //Overloaded version
                Console.WriteLine("\n >> ToDictionary Overload-2 << \n ");
                List<Product> listProducts1 = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1001, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };

                ///throws a System.ArgumentException as there are two products with the same ID (i.e. products with id 1001) 
                ///and we are using ID as the key for the dictionary.
                ///
                Dictionary<int, string> productsDictionary2 = listProducts1.ToDictionary(x => x.ID, x => x.Name);
                foreach (KeyValuePair<int, string> kvp in productsDictionary2)
                {
                    Console.WriteLine("Key : " + kvp.Key + " Value : " + kvp.Value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
