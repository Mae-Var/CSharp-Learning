using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_in_depth
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Boyan Popov ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // removes the blank space in the end of the name.
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.ToLower());

            var index = fullName.IndexOf(' '); // tracks index of blank space
            string firstName = fullName.Substring(0, index); //takes 1st part of the fullName till it reaches index (i.e. blank space)
            string lastName = fullName.Substring(index + 1); // takes the part after blank space.
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name after .Split: " + names[0]);
            Console.WriteLine("Last name after .Split: " + names[1]);
        }
    }
}
