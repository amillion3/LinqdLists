using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class OrderNames
    {
        public static void OrderTheseNames()
        {
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
        }
    }
}
