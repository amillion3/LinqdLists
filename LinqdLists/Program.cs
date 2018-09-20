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
            foreach (int f in fourSixMultiples) {
                Console.WriteLine(f);
            };
            Console.ReadLine();
            Console.WriteLine("");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
                {
                    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                    "Francisco", "Tre"
                };

            var descend = from name in names
                          orderby name descending
                          select name;

            Console.WriteLine("Descending names:");
            foreach (string f in descend)
            {
                Console.WriteLine(f);
            };
            Console.ReadLine();
            Console.WriteLine("");

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
;