using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise___Unique_Number_into_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = new List<int>();
            List<int> uniqueNums = new List<int>();

            // Console.WriteLine("Please, add numbers and once you want to see the result, type in 'quit':");

            Console.Write("Enter a number or 'quit' to exit and see all the unique numbers: ");

            while (true)
            {
                Console.Write("Enter next number or 'quit': ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    uniqueNums = listOfNums.Distinct().ToList();
                    foreach (int num in uniqueNums)
                    {
                        Console.WriteLine("This is one of the unique numbers: {0}", num);
                    }
                    break;
                }
                listOfNums.Add(Convert.ToInt32(input));
            }
        }
    }
}
