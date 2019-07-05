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
            Console.WriteLine(CheckForAnagram("Elvis", "lives").ToString()); //true
            Console.WriteLine(CheckForAnagram("aaee", "aeee").ToString()); //false
            Console.WriteLine(CheckForAnagram("Astronomer", "Moon starer").ToString()); //true
            Console.WriteLine(CheckForAnagram("Conversation", "Voices rant on").ToString()); //true
            Console.WriteLine(CheckForAnagram("Conversation", "Voices rant off").ToString()); //false
            Console.WriteLine(CheckForAnagram(null, null).ToString()); // expected true
            Console.WriteLine(CheckForAnagram("hehe", null).ToString()); // expected false
        }
        static bool CheckForAnagram(string a, string b)
        {
            //[YOUR CODE HERE]

            if (a == b)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            a = a.Replace(" ", string.Empty).ToLower();
            b = b.Replace(" ", string.Empty).ToLower();

            char[] arrayA = a.ToCharArray();
            char[] arrayB = b.ToCharArray();
            Array.Sort(arrayA);
            Array.Sort(arrayB);

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] != arrayB[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

//google searches: 

//10:57 AM
//c# remove empty space from string - Google Search
//www.google.com
//10:55 AM
//Remove Whitespace from C# Strings : C# 411
//www.csharp411.com
//10:50 AM
//c# - Efficient way to remove ALL whitespace from String? - Stack Overflow
//stackoverflow.com
//10:50 AM
//c# string.empty - Google Search
//www.google.com
//10:47 AM
//String.Empty Field (System) | Microsoft Docs
//docs.microsoft.com