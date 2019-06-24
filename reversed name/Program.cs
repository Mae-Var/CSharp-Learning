using System;

namespace reversed_name
{
    class Program
    {
        public static string ReversedName(string name)
        {
            char[] letter = name.ToCharArray();

            for (int i = 0; i < letter.Length / 2; i++) // adding / 2 so the reversal wont go
            {
                char temp = letter[i]; // N out of STEFAN
                letter[i] = letter[letter.Length - 1 - i]; //Output: NAFFAN
                letter[letter.Length - 1 - i] = temp; //Output: STEFAN
            }
            string s = new string(letter);
            return s;

            //char[] letter = name.ToCharArray();

            //for (int i = 0, j = letter.Length - 1; i < j; i++, j--)
            //{
            //    char tempChar = letter[i];
            //    letter[i] = letter[j];
            //    letter[j] = tempChar;
            //}
            //string s = new string(letter);
            //return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name here: ");
            string input = Console.ReadLine();
            Console.WriteLine(ReversedName(input));
        }
    }
}


//Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.