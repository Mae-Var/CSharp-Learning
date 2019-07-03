using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_BUILDER
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First character: " + builder[0]);
        }
    }
}

// YOU CAN ALSO DO IT LIKE THIS: 

//var builder = new StringBuilder("Hello World");
//            .Append('-', 10);
//            .AppendLine();
//            .Append("Header");
//            .AppendLine();
//            .Append('-', 10);
//            .Replace('-', '+');
//            .Remove(0, 10);
//            .Insert(0, new string ('-', 10));
