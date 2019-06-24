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
            

            // Console.WriteLine("Please, add numbers and once you want to see the result, type in 'quit':");

            Console.Write("Enter a number or 'Quit' to exit and see all the unique numbers: ");

            while (true)
            {
                Console.Write("Enter next number or 'Quit': ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Below are all unique numbers:");

                    var uniques = new List<int>();
                    foreach (int num in listOfNums)
                    {
                        if (!uniques.Contains(num))
                        {
                            uniques.Add(num);
                        }
                    }

                    foreach (int num in uniques)
                    {
                        Console.WriteLine(num);
                    }
                    break;
                }
                listOfNums.Add(Convert.ToInt32(input));
            }
        }
    }
}

// List<int> uniqueNums = new List<int>();
// uniqueNums = listOfNums.Distinct().ToList(); // this is the fastest way, but you need to know how to do it without this method.