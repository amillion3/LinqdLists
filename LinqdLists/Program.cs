using System;
using System.Collections.Generic;

namespace LinqdLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>
            {
                "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"
            };
            char matchingLetter = 'l';
            IEnumerable<string> query1 = from fruit in fruits
                                         where fruit.StartsWith < matchingLetter >
                                         select fruit;

            foreach (var abc in query1)
            {
                Console.WriteLine(abc);
            }
        }
    }
}
