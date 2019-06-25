using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);

            // they are immutable.
            // now.Add by typing .Add, you can modify them.

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow's date will be: " + tomorrow.Date);
            Console.WriteLine("Tomorrow's date will be: " + yesterday.Date);

            Console.WriteLine(now.ToLongDateString()); // 25 June, 2019
            Console.WriteLine(now.ToShortDateString()); // 25-Jun-19
            Console.WriteLine(now.ToLongTimeString()); // 1:25:30 PM
            Console.WriteLine(now.ToShortTimeString()); // 1:25 PM

            Console.WriteLine(now.ToString()); // 25-Jun-19 1:31:51 PM
            Console.WriteLine(now.ToString("dd-MM-yy HH:mm")); // 25-06-19 13:34

            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Time Span: " + timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0); // not very readable
            // var timeSpan2 = new TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration); // creating timespan object.



            // PROPERTIES:
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // ADD (timespan is immutable)
            Console.WriteLine("ADD example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("SUBTRACT example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString example: " + timeSpan.ToString()); //converts the value to a string

            // Parse
            Console.WriteLine("Parse example: " + TimeSpan.Parse("01:02:03"));

            Console.WriteLine("Current Year: " + DateTime.Now.Year);
        }
    }
}
