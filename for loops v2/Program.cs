using System;

namespace for_loops_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Wick";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name) // same as the above, but with foreach method
            {
                Console.WriteLine(character);
            }
        }
    }
}
