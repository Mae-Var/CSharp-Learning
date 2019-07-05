using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Check if a and b are anagrams of each other. (You can get the second one by rearanging the letters of the first one)*/

namespace Lemberg_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForAnagram("Elvis", "lives").ToString());
            Console.WriteLine(CheckForAnagram("aaee", "aeee").ToString());
            Console.WriteLine(CheckForAnagram("Astronomer", "Moon starer").ToString());
            Console.WriteLine(CheckForAnagram("Conversation", "Voices rant on").ToString());
            Console.WriteLine(CheckForAnagram("Conversation", "Voices rant off").ToString());
        }
        static bool CheckForAnagram(string a, string b)
        {
            //[YOUR CODE HERE]
        }
    }
    //Expected output:
    //true
    //false
    //true
    //true
    //false
}
