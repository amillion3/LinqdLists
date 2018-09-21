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

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };
            Console.WriteLine("Count the number of numbers:");
            Console.WriteLine(numbers3.Count);
            Console.ReadLine();
            Console.WriteLine("");


            // How much money have we made?
            List<double> purchases = new List<double>()
                {
                    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
                };
            Console.WriteLine("Sum the numbers:");
            Console.WriteLine(purchases.Sum());
            Console.ReadLine();
            Console.WriteLine("");




            // What is our most expensive product?
            List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };
            Console.WriteLine("Most expensive product?");
            Console.WriteLine(prices.Max());
            Console.ReadLine();
            Console.WriteLine("");


            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
        */
            List<int> wheresSquaredo = new List<int>()
                {
                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                };

            List<int> shortOne = new List<int>();

            var abcdef = from number3 in wheresSquaredo
                         where Math.Sqrt(number3) != Convert.ToInt32(Math.Sqrt(number3))
                         select number3;

            Console.WriteLine("Squared numbers:");
            foreach (var f in abcdef)
            {
                shortOne.Add(f);
                Console.WriteLine(f);
            }
            Console.ReadLine();
            Console.WriteLine("");

        }
    }
}
;