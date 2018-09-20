using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var matches = from fruit in fruits
                          where fruit.StartsWith("L") == true
                          select fruit;

            Console.WriteLine("Fruits that begin with an L character: ");
            foreach (string f in matches)
            {
                Console.WriteLine(f);
            };
            Console.ReadLine();
            Console.WriteLine("");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            var fourSixMultiples = from number in numbers
                                   where number % 4 == 0 || number % 6 == 0
                                   select number;

            Console.WriteLine("4 and 6 multiples:");
            foreach (int f in fourSixMultiples) { Console.WriteLine(f); };
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
;