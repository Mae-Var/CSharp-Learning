using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Spring;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("We've got promotion!");      // if the season is Autumn OR Spring, this piece of code will be executed.
                    break;

                case Season.Summer:
                    Console.WriteLine("It's summer. It is so hot, I wish there was a sea nearby.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's winter time! Beautiful, but cold.");
                    break;
            }
        }
    }
}
