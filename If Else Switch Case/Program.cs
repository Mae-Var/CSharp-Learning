using System;


namespace If_Else_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 19;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }
        }
    }
}
