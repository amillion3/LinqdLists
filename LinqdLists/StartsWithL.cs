﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    public class StartsWithL
    {
        public static void FruitThatStartsWithL()
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
        }
    }
}
