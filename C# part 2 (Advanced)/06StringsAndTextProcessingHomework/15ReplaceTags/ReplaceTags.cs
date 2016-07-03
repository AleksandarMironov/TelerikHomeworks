using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string pattern = @"<a href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            //string replace = @"[URL href=$1]$2[/URL]";
            //string replaced = Regex.Replace(input, pattern, replace);
            //Console.WriteLine(replaced);

            var openTag = @"<a ";
            var closeTag = @"</a>";

            var toParse = Console.ReadLine()
                .Split(new[] { openTag, closeTag },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int strIndex = 0; strIndex < toParse.Length; strIndex++)
            {
                if (toParse[strIndex].IndexOf("href=") == 0)
                {
                    var url = GetURL(toParse[strIndex]);
                    var label = GetLabel(toParse[strIndex]);

                    Console.Write("[{0}]({1})", label, url);
                }
                else
                {
                    Console.Write(toParse[strIndex]);
                }
            }
        }

        static string GetURL(string tag)
        {
            var left = tag.IndexOf("\"");
            var right = tag.IndexOf("\"", left + 1);

            return tag.Substring(left + 1, right - left - 1);
        }

        static string GetLabel(string tag)
        {
            var left = tag.IndexOf(">");
            var right = tag.IndexOf("<", left + 1);

            return tag.Substring(left + 1);

        }
    }
}
