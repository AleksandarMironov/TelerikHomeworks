using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            string wordToCount = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int counter = 0;
            int tempStart = 0;
            int next = 0;
            while (tempStart < text.Length- wordToCount.Length && next > -1)
            {
                next = text.IndexOf(wordToCount, tempStart);
                if (next > -1)
                {
                    counter++;
                }
                tempStart = next + 1;
            }
            Console.WriteLine(counter);
        }
    }
}
