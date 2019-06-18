using System;

namespace exercise_4._5___input_numbers_to_array_and_show_highest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter comma separated numbers: ");

            string input = Console.ReadLine();
            var numbers = input.Split(',');
            int max = Convert.ToInt32(numbers[0]);

            foreach (var digit in numbers)
            {
                var number = Convert.ToInt32(digit);
                if (number > max)
                {
                    max = number;
                }
            };
            Console.WriteLine("Max number is: " + max);
        }
    }
}
