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
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            };

            Console.WriteLine("Index of 1 is: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1 is: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            numbers.Remove(1); // removes the first number 1 in the list.

            for (int i = 0; i < numbers.Count; i++) // if you want to remove all numbers 1 from the list, use for loop - you CANNOT use foreach method.
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            };

            numbers.Clear();
            Console.WriteLine("Count after .Clear() method: " + numbers.Count);
        }
    }
}
