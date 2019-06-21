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

                if (!uniqueNums.Contains(input))
                {
                    uniqueNums.Add(input);
                }
                else
                {
                    Console.WriteLine("Please, input unique number.");
                }
            }
            //uniqueNums.Sort();

            int temp = 0;

            for (int i = 0; i < uniqueNums.Count; i++) // we're adding -1 on count so we could compare last element with the 1st element without going out of bounds.
            {
                for (int j = 0; j < uniqueNums.Count - 1; j++)
                {
                    if (uniqueNums[j] > uniqueNums[j + 1])
                    {
                        temp = uniqueNums[j + 1];
                        uniqueNums[j + 1] = uniqueNums[j];
                        uniqueNums[j] = temp;
                    }
                }
            }

            //for (int write = 0; write < uniqueNums.Count; write++)
            //{
            //    for (int sort = 0; sort < uniqueNums.Count - 1; sort++)
            //    {
            //        if (uniqueNums[sort] > uniqueNums[sort + 1])
            //        {
            //            temp = uniqueNums[sort + 1];
            //            uniqueNums[sort + 1] = uniqueNums[sort];
            //            uniqueNums[sort] = temp;
            //        }
            //    }
            //}

            Console.WriteLine("Sorted: ");
            foreach (int item in uniqueNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
