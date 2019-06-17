using System;

namespace string_count_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringchu = "The quick brown fox";
            string[] words = stringchu.Split(' ');
            Console.WriteLine(words.Length);
        }
    }
}
