using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class Multiples4and6
    {
        public static void GetMultiples ()
        {
            // Which of the following numbers are multiples of 4 or 6
            List<int> someNumbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            var fourSixMultiples = from number in someNumbers
                                   where number % 4 == 0 || number % 6 == 0
                                   select number;

            Console.WriteLine("4 and 6 multiples:");
            foreach (int f in fourSixMultiples)
            {
                Console.WriteLine(f);
            };
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
