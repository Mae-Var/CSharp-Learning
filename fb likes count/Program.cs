using System;
using System.Collections.Generic;

namespace exercise_3._1___facebook_likes_and_names
{
    class Program
    {
        static void Main(string[] args)
        {

            var peopleList = new List<string>();

            while (true)
            {
                Console.Write("Add a name, or press ENTER to quit: ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                peopleList.Add(input);
            }

            if (peopleList.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {3} others like your post.", peopleList[0], peopleList[1], peopleList.Count - 2);
            }
            else if (peopleList.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", peopleList[0]);
            }
            else if (peopleList.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", peopleList[0], peopleList[1]);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
