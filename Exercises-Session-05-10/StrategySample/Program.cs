using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer("Hadi", 30),
                new Customer("Alice", 20),
                new Customer("Tom", 40),
                new Customer("HADI", 10),
            };
            var ordered = customers.Distinct(new AgeEquality()).ToList();   //Passing strategy into context
            
            Console.WriteLine("Hello World!");
        }
    }
}
