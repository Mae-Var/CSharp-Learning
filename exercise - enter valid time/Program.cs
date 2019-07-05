using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise___enter_valid_time
{
    class Program
    {
        public static bool isDateTime(string input)
        {
            try
            {
                DateTime valid = DateTime.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter valid (HH:MM) time: ");
            string input = Console.ReadLine();

            if (isDateTime(input))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
