using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class SortNumbers
    {
        public static void SortSomeNumbers()
        {
            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var sortEm = from number2 in numbers2
                         orderby number2 ascending
                         select number2;

            List<int> sortedNumbers = new List<int>();

            Console.WriteLine("Ascending numbers:");
            foreach (var f in sortEm)
            {
                sortedNumbers.Add(f);
                Console.WriteLine(f);
            }
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
