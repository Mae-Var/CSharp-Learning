using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise___enter_or_dups
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by '-': ");
            List<int> numbers = new List<int>();
            List<int> dups = new List<int>();
            var input = Console.ReadLine();


            if (!String.IsNullOrEmpty(input))
            {
                string[] tempVar;
                tempVar = input.Split('-');

                foreach (var num in tempVar)
                {
                    if (!(numbers.Contains(Convert.ToInt32(num))))
                    {
                        numbers.Add(Convert.ToInt32(num));
                    }
                    else
                    {
                        dups.Add(Convert.ToInt32(num));
                    }
                }
            }
            else
            {
                Console.WriteLine("Empty input..commence closure...404");
                return;
            }

            foreach (var item in dups)
            {
                Console.WriteLine("Item is a duplicate: {0}", item);
            }

        }
    }
}
