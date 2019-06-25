using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise___3_smallest_ints_from_5_or_more
{
    // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
    // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
    class Program
    {
        static void Main(string[] args)
        {   
            string[] inputString;

            while (true)
            {
                Console.Write("Enter a list of comma separated (e.g 5, 1, 9, 2, 10) numbers: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    inputString = input.Split(',');
                    if (inputString.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in inputString)
            numbers.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallest) {
            Console.WriteLine(number);
            }
        }
    }
}
