using mooooore_strings_and_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is going to be really really really really really long text.";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }

    }
}
