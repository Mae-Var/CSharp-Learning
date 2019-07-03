using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise___consecutive_or_not_ints
{
    //Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
    // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few dash separated (e.g 1-2-3-4...) numbers: ");
            string input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            bool consecutiveness = false;

            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (!(numbers[i] + 1 == numbers[i + 1] || numbers[i] - 1 == numbers[i + 1]))
                {
                    break;
                }
                else
                {
                    consecutiveness = true;
                }
            }

            if (consecutiveness)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}


//numbers.Sort();

//            bool isConsecutive = false;

//            for (var i = 0; i<numbers.Count - 1; i++)
//            {
//                int temp1 = numbers[i] - 1;
//int temp2 = numbers[i] + 1;
//                if (temp1 == numbers[i] || temp2 == numbers[i])
//                {
//                    Console.WriteLine("Consecutive");
//                } else
//                {
//                    Console.WriteLine("Not Consecutive");
//                }
//            }