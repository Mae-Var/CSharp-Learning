using System;

namespace Exercise_4___speed_limit
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int inputSpeed;
            Console.WriteLine("Enter what is the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The speed limit is: " + speedLimit);
            Console.WriteLine("Please, enter the speed used by the driver: ");
            inputSpeed = Convert.ToInt32(Console.ReadLine());

            int demeritPerKM = 5;
            int overTheLimit = inputSpeed - speedLimit;
            int demeritPoints = overTheLimit / demeritPerKM;

            if (inputSpeed < speedLimit)
            {
                Console.WriteLine("Your speed was " + inputSpeed + ", which is within the allowed limit. Thanks for the cooperation!");
            }
            else
            {
                if (demeritPoints < 12)
                {
                    Console.WriteLine("Your speed was " + overTheLimit + "km/h over the limit. This results in " + demeritPoints + " demerit points.");
                }
                else
                {
                    Console.WriteLine("Your speed was " + overTheLimit + "km/h over the limit. This results in " + demeritPoints + " demerit points.\n*LICENSE SUSPENDED*");
                }
            }
        }
    }
}
