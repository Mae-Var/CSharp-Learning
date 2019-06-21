using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 }; // array cannot change it's length, but lists can.
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7});
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            };

            Console.WriteLine("Index of 1 is: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1 is: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
