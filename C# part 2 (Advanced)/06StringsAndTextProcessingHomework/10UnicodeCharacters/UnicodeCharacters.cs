using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10UnicodeCharacters
{
    class UnicodeCharacters
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }

        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetEscapeSequence(input[i]));
            }

        }

    }
}

