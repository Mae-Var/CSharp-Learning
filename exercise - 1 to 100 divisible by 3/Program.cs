using System;

namespace exercise___1_to_100_divisible_by_3
{
    class Program
    {
        public static string DevisibleByThree()
        {
            int counter = 0;
            string ret1 = "The total of numbers divisble by 3 between 1-100 is ";
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }
            return ret1 + counter + ".";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DevisibleByThree());
        }

    }
}
