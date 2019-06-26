using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace mooooore_strings_and_classes
{
    public class StringUtility
    {
        public static object Console { get; internal set; }

        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            // sentence.Substring(0, maxLength); // if you leave this as it is, it might cut a word in half which is not good. Use the below instead:
            var words = text.Split(' ');
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalChars += word.Length + 1;
                if (totalChars > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";
        }

    }
}
