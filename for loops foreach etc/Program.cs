using System;

namespace for_loops_foreach_etc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
