using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            var wordToFind = Console.ReadLine();
            var input = Console.ReadLine();

            var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var separators = input.Where(x => !char.IsLetter(x)).Distinct().ToArray();

            var wordCapitalized = wordToFind.Replace(wordToFind[0], char.ToUpper(wordToFind[0]));
            var wordNormalized = wordToFind.Replace(wordToFind[0], char.ToLower(wordToFind[0]));

            foreach (var sentence in sentences)
            {
                var words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Trim() == wordToFind)
                    {
                        Console.Write(sentence.Trim() + ". ");
                        break;
                    }
                }
            }
            //string word = Console.ReadLine().ToLower();
            //string[] text = Console.ReadLine().Split('.');
            //List<string> output = new List<string>();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (Regex.Matches(text[i].ToLower(), @"\b" + word + @"\b").Count > 0)
            //    {
            //        output.Add(text[i].Trim());
            //    }
            //}
            //Console.WriteLine(String.Join( ". ", output)+".");
        }
    }
}
