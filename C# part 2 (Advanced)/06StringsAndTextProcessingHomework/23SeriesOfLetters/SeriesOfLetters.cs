using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            char [] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    input[i] = ' ';
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
