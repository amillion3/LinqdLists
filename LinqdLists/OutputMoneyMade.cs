using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class OutputMoneyMade
    {
        public static void HowMuchTotal()
        {
            // How much money have we made?
            List<double> purchases = new List<double>()
                    {
                        2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                    };
            Console.WriteLine("Sum the numbers:");
            Console.WriteLine(purchases.Sum());
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
