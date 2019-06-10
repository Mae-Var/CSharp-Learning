using System;

namespace loops___random_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122)); // (char) will convert the numbers to ASCII code >>> characters i.e. letters.
            }
        }
    }
}
