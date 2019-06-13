using System;

namespace exercise_2._2___calc_all_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Add a valid number or 'ok' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("The total of all accumulated numbers is: " + sum);
        }
    }
}
