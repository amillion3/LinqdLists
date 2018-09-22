﻿using System;
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

            var richPeople = from c in customers
                             where c.Balance >= 1000000
                             select c;
            // var richPeople = customers.Where(c => c.Balance > 1000000);

            var richPeoplePerBank = customers
                .GroupBy(c => c.Bank) // Groups customers by Bank (the symbol of the bank)
                .Aggregate(new Dictionary<string, int>(), (acc, current) =>
                {
                    acc.Add(current.Key, current.Where(x => x.Balance > 1000000).Count());
                    return acc;
                });

            //var millionairesPerBank = customers
            //    .GroupBy(cust => cust.Bank)
            //    .Aggregate(new Dictionary<string, int>(), (acc, current) =>
            //    {
            //        acc.Add(current.Key, current.Where(x => x.Balance > 1000000).Count());
            //        return acc;
            //    });

            //foreach (var bank in millionairesPerBank)
            //{
            //    Console.WriteLine($"Bank: {bank.Key}, Millionaires: {bank.Value}");
            //}


            //var joinedList = from c in customers
            //                 join b in banks on c.Bank equals b.Symbol into bs
            //                 select new { Customer = c, BankSymbol = bs };
            //foreach( var j in joinedList)
            //{
            //    Console.WriteLine(value: j.BankSymbol.ToString());
            //}


            //foreach (var r in results)
            //{
            //    Console.WriteLine(r.BankName[0]);
            //    Console.WriteLine(r.NameId);
                
            //}

            //var queryLastNames =
            //                    from student in students
            //                    group student by student.LastName into newGroup
            //                    orderby newGroup.Key
            //                    select newGroup;

            //var results = from p in persons
            //              group p.car by p.PersonId into g
            //              select new { PersonId = g.Key, Cars = g.ToList() };

            //HashSet<string> uniqueBankSymbols = new HashSet<string>();
            //Dictionary<string, int> bankCount = new Dictionary<string, int>();

            //var joinedList = from c in customers
            //                 join b in banks on c.Bank equals b.Symbol into bs
            //                 select new { Customer = c, BankSymbol = bs };

            //foreach(var j in joinedList)
            //{
            //    uniqueBankSymbols.Add(item: j.Customer.Bank);
            //}

            //foreach(var ubs in uniqueBankSymbols)
            //{
            //    Console.WriteLine(ubs);
            //    bankCount.Add(ubs, 0);
            //}

            //foreach(var jjj in joinedList)
            //{
            //    bankCount.Aggregate(jjj.BankSymbol)
            //}
            //var bankSymbols = joinedList.GroupBy(b => b.Bank);

            //foreach (var bb in bankSymbols)
            //{
            //    Console.WriteLine(value: bb.Key);
            //    Console.WriteLine(bb.ToString());
            //    foreach (var i in bb)
            //    {
            //        Console.WriteLine(value: "\t" + i.Customer.Bank);
            //    }
            //}

            //var bankCounts = from j in joinedList
            //                 select new {bankSymbol = j.Bank, OrderCount = j.Bank.Count() };
            //foreach (var bb in bankCounts)
            //{
            //    foreach (var abcd in bb.bankSymbol)
            //    {
            //        Console.WriteLine(abcd.Symbol);
            //        Console.WriteLine(abcd.Name);
            //    }
            //    //Console.WriteLine(bb.OrderCount);
            //    //Console.WriteLine(bb.bankSymbol);
            //}

            Console.ReadLine();
            Console.WriteLine("");

            //public void Linq76()
            //{
            //    List<Customer> customers = GetCustomerList();

            //    var orderCounts =
            //        from c in customers
            //        select new { c.CustomerID, OrderCount = c.Orders.Count() };

            //    ObjectDumper.Write(orderCounts);
            //}
            //var bankSymbols = joinedList.ToLookup(b => b.Bank);

            //foreach (var bb in bankSymbols)
            //{
            //    //Console.WriteLine(bb.Key);
            //    foreach (var item in bb)
            //    {
            //        Console.WriteLine(value: item.Bank.Count());
            //    }
            //}

            //HashSet<string> bankSymbols = new HashSet<string>();

            //foreach (var j in joinedList)
            //{
            //    foreach(var k in j.Bank)
            //    {
            //        bankSymbols.Add(k.Symbol);
            //    }
            //    //Console.WriteLine(j.Customer.Name);
            //    //Console.WriteLine(j.Customer.Bank);
            //}
            //foreach (var bb in bankSymbols)
            //{
            //    Console.WriteLine(bb);
            //}


            //var results = from r in richPeople
            //              group r.Bank by r.Name into g
            //              select new { Name = g.Key, Bank = g.ToList() };
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
