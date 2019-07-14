using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3S_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
            Console.WriteLine("Please, enter any amount of letters or strings: "); // intentionally not making it for 3 chars only.

            string stringlet = Console.ReadLine();
            char[] charArr = stringlet.ToCharArray();

            foreach (char item in charArr.Reverse())
            {
                Console.Write(item);
            }
            Console.WriteLine();

            // 2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.

            // List<int> listFullOfInts = Enumerable.Repeat(42, 50).ToList();
            // If you already have a list and you don't want to create a new one with ToList:
            // listFullOfInts.AddRange(Enumerable.Repeat(42, 50));
            // listOfDigits.ForEach(Console.WriteLine);

            Console.WriteLine("Enter a number filling the triangle: ");
            int numberFilling = NumCheck();

            Console.WriteLine("Now enter a desired width for the triangle: ");
            int width = NumCheck();
            int height = width;

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(numberFilling);
                }
                Console.WriteLine();
                width--;
            }

            //List<int> listOfDigits = Enumerable.Repeat(numberFilling, width).ToList();
            //string output = String.Join("", listOfDigits);

            //for (int i = 1; i < width; i++)
            //{
            //    Console.WriteLine(output[output.Length - i]);
            //}


            // 3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.

            Console.WriteLine(UserAndPass());




            // 4. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.

        }

        private static string UserAndPass()
        {
            int counter = 0;
            string unm = "SalimX";
            string pwd = "RealSlim1337";

            while (counter != 3)
            {
                Console.WriteLine("Please, write your username below: \n");

                if (Console.ReadLine() != unm)
                {
                    Console.WriteLine("There's no such username in the system.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Username: OK");
                    break;
                }
            }

            while (counter != 3)
            {
                Console.WriteLine("Please, write your password below: \n");

                if (Console.ReadLine() != pwd)
                {
                    Console.WriteLine("The password is incorrect.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Password: OK");
                    break;
                }
            }
            return "You've successfully logged in.";
        }

        //private static string UserName()
        //{
        //    int counter = 0;
        //    string unm = "SalimX";

        //    Console.WriteLine("Please, write your username below: \n");

        //    while (counter != 3)
        //    {
        //        if (Console.ReadLine() != unm)
        //        {
        //            counter++;
        //            Console.WriteLine("There's no such username in the system.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Username: OK");
        //            return "";
        //        }
        //    }
        //    Environment.Exit(0);
        //    return "Disconnecting.";
        //}
        //private static string UserPass()
        //{
        //    int counter = 0;
        //    string pwd = "RealSlim1337";
        //    Console.WriteLine("Please, write your password below: \n");

        //    while (counter != 3)
        //    {
        //        if (Console.ReadLine() != pwd)
        //        {
        //            counter++;
        //            Console.WriteLine("The password is incorrect.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Password: OK");
        //            return "";
        //        }
        //    }
        //    Environment.Exit(0);
        //    return "Disconnecting.";
        //}
        private static int NumCheck()
        {
            int x;

            Console.Write("Enter a valid number (int): ");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("This is not a number, try again: ");
            }
            return x;
        }
    }
}
