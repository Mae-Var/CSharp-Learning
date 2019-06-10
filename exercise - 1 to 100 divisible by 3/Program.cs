using System;

namespace exercise___1_to_100_divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }
            Console.WriteLine("The total of numbers divisble by 3 between 1-100 is: {0}", counter);
        }
    }
}
