using System;

namespace loops___random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10)); //random numbers will be between 1 and 10.
            }

            Console.WriteLine("Below we'll be generating a random password:");

            Console.WriteLine((int)'a'); // 'a' == 97 as per ASCII table.
        }
    }
}
