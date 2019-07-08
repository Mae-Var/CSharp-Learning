using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemberg_2nd_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input one of the below commands: ");
            Console.WriteLine("1) T or Time to get current time of the day.");
            Console.WriteLine("2) D or Date to get current date of the year.");
            Console.WriteLine("3) S or Sum to summarize 2 numbers.");
            Console.WriteLine("4) Q or Quit to exit.");

            string input = Console.ReadLine().ToLower();

            if (input == "t" || input == "time")
            {
                string timeNow = DateTime.Now.ToString("hh:mm tt");
                Console.WriteLine("The time is: " + timeNow);

            }
            else if (input == "d" || input == "date")
            {
                string dateNow = DateTime.Now.ToString("yyyy-MMM-dd");
                Console.WriteLine("The date is: " + dateNow);

            }
            else if (input == "s" || input == "sum")
            {
                Console.WriteLine("Please, enter first number: ");
                int one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter second number: ");
                int two = Convert.ToInt32(Console.ReadLine());

                int sum = one + two;

                Console.WriteLine("The sum is: {0}.", sum);
            }
            else if (input == "q" || input == "quit")
            {
                Console.WriteLine("Leaving the console...");
                return;
            }
            else
            {
                Console.WriteLine("You have used an unknown command - exiting now...");
                return;
            }

        }
    }
}


// googled: https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
