using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)     // x.Format() is a format method which takes few parameters. In the below example {0} will be replaced with firstName and {1} with lastName.
        {
            var firstName = "B";
            var lastName = "Popov";
            string fullName = firstName + " " + lastName;
            string fullName2 = string.Format("{0}, {1}", firstName, lastName); // this represents how the names will be shown i.e. there will be firstName comma lastName (B, Popov). the "{0}, {1}" is how it will execute the firstName + lastName
            string fullName3 = string.Format("My name is {0}. {1}.", firstName, lastName);

            var fewNames = new string[3] { "Jack", "John", "Jane" };
            var formattedFewNames = string.Join(", ", fewNames);

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);
            Console.WriteLine(formattedFewNames);

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);

            Console.WriteLine(list);

            string namePosition = "Maevar"; // Strings are IMMUTABLE - once created, it cannot be changed! If you use a method to change a string, it will return a new string - the original will never be changed.
            char firstChar = namePosition[0];

            Console.WriteLine(firstChar);

            string path = "C:\\Users\\ashel\\source\\repos\\Strings"; // instead of using double backslash //, you can use the below Verbatim String:
            string pathV2 = @"C:\Users\ashel\source\repos\Strings";

            var text = "Hi, John.\n Look into the following paths\nc:\\folder1"; // that's not clean...use the below instead:
            var betterText = @"Hi, John.
Look into the following paths:
c:\\folder1";

            Console.WriteLine(text);
            Console.WriteLine(betterText); // using Verbating String is much better, as show in var betterText = @ ...
        }
    }
}
