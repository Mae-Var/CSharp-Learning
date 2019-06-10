using System;

namespace loops___random_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLenght = 10;
            char[] buffer = new char[passwordLenght];

            for (var i = 0; i < passwordLenght; i++)

               buffer[i] = (char)('a' + random.Next(0, 26)); // this will fill the buffer array with random characters.

            string password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
