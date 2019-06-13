using System;

namespace exercise_4._4___random_number_1_to_10_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int randomnumber = random.Next(1, 11);
            int guessCounter = 0;
            bool answerStatus = false;

            // Console.WriteLine(randomnumber); // just a test to see that everything works as inteded.
            Console.WriteLine("Please, write down a number between 1 and 10: ");

            while (answerStatus == false) // try using (!answerStatus) and see the outcome.
            {
                guessCounter++;
                int guess = int.Parse(Console.ReadLine());

                if (guessCounter == 4)
                {
                    Console.WriteLine("You failed to guess the correct answer in {0} tries.", guessCounter);
                    break;
                }

                if (guess == randomnumber)
                {
                    answerStatus = true; // not sure if I need this here, since the if statement requires the guess to be equal to the random num.
                    Console.WriteLine("You won the game in {0} guesses!", guessCounter);
                    break;
                }
                
            };
        }
    }
}
