using System;

namespace exercise_3._3___compute_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a valid number to see it's factorial: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            Console.WriteLine("The total of all accumulated numbers is: " + sum);

        }

    }
}