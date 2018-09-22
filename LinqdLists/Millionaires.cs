using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class Millionaires
    {
        private static IEnumerable<object> g;

        // Build a collection of customers who are millionaires
        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        class Result
        {
            public int Name;
            public List<string> Banks;
        }

        public static void RichFolk()
            {
                List<Customer> customers = new List<Customer>() {
                    new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                    new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                    new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                    new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                    new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                    new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                    new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                    new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                    new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                    new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
                };

            var richPeople = from c in customers
                             where c.Balance >= 1000000
                             select c;

            //var results = from r in richPeople
            //              group r.Bank by r.Name into g
            //              select new { Name = g.Key, Bank = g.ToList() };
            List<Result> results1 = (
                    from p in richPeople
                    group p.Bank by p.Name into g
                    select new Result()
                    {
                        Name = g.,
                        Banks = g.ToList(),
                    }

            foreach (var res in g)
            {
                Console.WriteLine(res);
            }
            Console.ReadLine();
            Console.WriteLine("");

            //List<Result> results1 = (
            //from p in persons
            //group p by p.PersonId into g
            //select new Result()
            //{
            //    PersonId = g.Key,
            //    Cars = g.Select(c => c.car).ToList()
            //}

        /* 
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            Example Output:
            WF 2
            BOA 1
            FTB 1
            CITI 1
        */
    }
    }
}
