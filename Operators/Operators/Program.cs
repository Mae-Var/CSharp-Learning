
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 1;
            var d = 2;
            var e = 3;
            var f = true && false;

            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a / b);
            System.Console.WriteLine((float)a / (float)b); // if you skip the "float" part, the numbers will be whole i.e. giving you a result of 3. With the "float", you'll get the whole: 3.33
            System.Console.WriteLine(a % b);
            System.Console.WriteLine(c + d * e); // like im maths, * and / are with higher priority.
            System.Console.WriteLine((c + d) * e);
            System.Console.WriteLine(a > b); // boolean result i.e. true // false.
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(a != b);
            System.Console.WriteLine(!(a != b)); // avoid using double-negative. In this case we can use the == instead.
            System.Console.WriteLine(a > b && e > d); // this gives us: true && true = true;
            System.Console.WriteLine(a > b && e == d); // this gives us: true && false = false;
            System.Console.WriteLine(a > b || e == d); // this gives us: true OR false = true;
            System.Console.WriteLine(!(a > b || e == d)); // this gives us: true OR false = true, but then we reverse this with a !!!! i.e. False.
            System.Console.WriteLine(f); // false, because it points to be both true & false, but it's impossible so it's a "false".
        }
    }
}
