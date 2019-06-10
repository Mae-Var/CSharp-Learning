using System;

namespace SwitchCase
{

    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season) {
                case Season.Autumn:
                    Console.WriteLine("It's autumn! It's rainy and beautiful.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's spring. It's rainy and everything is green.");
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
