using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class PerfectSquare
    {
        public static void FindFirstPerfectSquare()
        {
            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
                {
                    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
                };

            var noSquares = wheresSquaredo.TakeWhile(i => Math.Sqrt(i) != Convert.ToInt32(Math.Sqrt(i)));

            List<int> shortOne = new List<int>();

            Console.WriteLine("Squared numbers:");
            foreach (var f in noSquares)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
