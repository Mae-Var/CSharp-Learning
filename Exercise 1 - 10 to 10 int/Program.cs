using System;

namespace Exercise_1___10_to_10_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter a number between 1 and 10:");
            input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("The number you have entererd is: " + input);
            }
            else
            {
                Console.WriteLine("Please, make sure you've entered a whole number between 1 and 10.");
            }
        }
    }
}
