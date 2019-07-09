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
            while (true)
            {
                Console.WriteLine("\nPlease input one of the below commands: ");
                Console.WriteLine("1) T or Time to get current time of the day.");
                Console.WriteLine("2) D or Date to get current date of the year.");
                Console.WriteLine("3) S or Sum to summarize 2 numbers.");
                Console.WriteLine("4) Q or Quit to exit.\n");

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
                    Console.WriteLine("Please, enter 2 numbers: ");

                    int one = NumCheck();
                    int two = NumCheck();

                    Console.WriteLine("The sum is: {0}.", Sum(one, two));
                }
                else if (input == "q" || input == "quit")
                {
                    Console.WriteLine("Leaving the console...");
                    break;
                }
                else
                {
                    Console.WriteLine("You have used an unknown command - please, use a valid one.");
                }
            }
        }
        private static int NumCheck()
        {
            int x;

            Console.Write("Enter two valid numbers (int): ");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("This is not a number, try again: ");
            }
            return x;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
