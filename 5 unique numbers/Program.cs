using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_unique_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> uniqueNums = new List<int>();
            Console.WriteLine("Input five unique numbers: ");

            while (uniqueNums.Count != 5)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (!uniqueNums.Contains(input)) // if uniqueNums DOES NOT contain X (input) specific number, then add the number.
                {
                    uniqueNums.Add(input);
                }
                else
                {
                    Console.WriteLine("Please, input unique number."); // otherwise, do not add the number and return this error.
                }
            }
            //uniqueNums.Sort();

            int temp = 0;

            for (int i = 0; i < uniqueNums.Count; i++)
            {
                for (int j = 0; j < uniqueNums.Count - 1; j++) // we're adding -1 on count so we could compare last element with the 1st element without going out of bounds.
                {
                    if (uniqueNums[j] > uniqueNums[j + 1])
                    {
                        temp = uniqueNums[j + 1];
                        uniqueNums[j + 1] = uniqueNums[j];
                        uniqueNums[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted: ");
            foreach (int item in uniqueNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
