using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class OutputExpensiveProduct
    {
        public static void MostExpensiveProduct()
        {
            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
            Console.WriteLine("Most expensive product?");
            Console.WriteLine(prices.Max());
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
