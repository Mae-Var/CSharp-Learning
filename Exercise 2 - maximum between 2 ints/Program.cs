using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___maximum_between_2_ints
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int input2;

            Console.WriteLine("Please, input 2 whole numbers:");

            input = Convert.ToInt32(Console.ReadLine());
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have entered the following numbers: " + "{0} & {1}", input, input2);

            if (input > input2)
            {
                Console.WriteLine("Highest number is: " + input);
            }
            else
            {
                Console.WriteLine("Highest number is: " + input2);
            }
        }
    }
}
