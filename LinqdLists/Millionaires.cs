using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqdLists
{
    class Millionaires
    {
        // Build a collection of customers who are millionaires

        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        public static void RichFolk()
            {
            // Create some banks and store in a List
                List<Bank> banks = new List<Bank>() {
                    new Bank(){ Name="First Tennessee", Symbol="FTB"},
                    new Bank(){ Name="Wells Fargo", Symbol="WF"},
                    new Bank(){ Name="Bank of America", Symbol="BOA"},
                    new Bank(){ Name="Citibank", Symbol="CITI"},
                };

            // Create some customers and store in a List
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

            //var richPeople = from c in customers
            //                 where c.Balance >= 1000000
            //                 select c;

            var joinedList = from c in customers
                             join b in banks on c.Bank equals b.Symbol into ps
                             select new { Customer = c, Bank = ps };

            foreach (var j in joinedList)
            {
                Console.WriteLine(j.Bank);
                Console.WriteLine(j.Customer);
            }
            Console.ReadLine();
            Console.WriteLine("");

            //string[] categories = new string[]{
            //    "Beverages",
            //    "Seafood" };

            //List<Product> products = GetProductList();

            //var q =
            //    from c in categories
            //    join p in products on c equals p.Category into ps
            //    select new { Category = c, Products = ps };

            //foreach (var v in q)
            //{
            //    Console.WriteLine(v.Category + ":");
            //    foreach (var p in v.Products)
            //    {
            //        Console.WriteLine("   " + p.ProductName);
            //    }
            //}


            //var results = from r in richPeople
            //              group r.Bank by r.Name into g
            //              select new { Name = g.Key, Bank = g.ToList() };

            //foreach (var res in g)
            //{
            //    Console.WriteLine(res);
            //}
            //Console.ReadLine();
            //Console.WriteLine("");



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
