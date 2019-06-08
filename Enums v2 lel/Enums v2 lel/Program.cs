using System;

namespace Enums_v2_lel
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Enum.GetName(typeof(WeekDays), 4)); // Friday

            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(str); // All days of the week
            }
            Console.WriteLine("Enum.TryParse():");

            WeekDays wdEnum;
            Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum); // Tuesday
        }
    }
}


//Points to Remember :
//The enum is a set of named constants.
//The value of enum constants starts from 0 (same as arrays). Enum can have value of any valid numeric type.
//String enum is not supported in C#.
//Use of enum makes code more readable and manageable.
// test