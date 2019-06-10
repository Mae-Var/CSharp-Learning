using System;

namespace Exercise_3___landscape_or_portrait
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int input2;

            Console.WriteLine("Please, input width of your image:");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input height of your image:");
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have entered the following parameters: " + "{0} & {1}", input, input2);

            if (input > input2)
            {
                Console.WriteLine("Since the width is " + input + " and the height is " + input2 + ", the image is a Landscape-oriented.");
            }
            else
            {
                Console.WriteLine("Since the width is " + input + " and the height is " + input2 + ", the image is a Portrait-oriented.");
            }
        }
    }
}
