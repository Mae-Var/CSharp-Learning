using System;

namespace Enums // Enumeration, by default it's integer, duh
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,         // it's always better to assing something to the enums.
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;        // converting enum to integer.
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);        // converting enum from integer.

            Console.WriteLine(method.ToString());                // converting enum to string.

            var methodName = "Express"; // Parsing = converting X to a different type.

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //object parse(type,string) /Enum.Parse/ Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object
            Console.WriteLine(shippingMethod);
        }
    }
}


