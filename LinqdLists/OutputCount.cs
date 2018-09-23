using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class OutputCount
    {
        public static void CountTheseNumbers()
        {
            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            Console.WriteLine("Count the number of numbers:");
            Console.WriteLine(numbers3.Count);
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
