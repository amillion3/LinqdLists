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

            foreach (var f in matches)
            {
                Console.WriteLine(f);
            };
            Console.ReadLine();

        }
    }
}
;