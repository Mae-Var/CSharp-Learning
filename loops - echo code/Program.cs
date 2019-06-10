using System;

namespace loops___echo_code
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your name: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; // continues to the beginning of the loop i.e. to the while (true)
                }
                break;
            }
        }
    }
}
