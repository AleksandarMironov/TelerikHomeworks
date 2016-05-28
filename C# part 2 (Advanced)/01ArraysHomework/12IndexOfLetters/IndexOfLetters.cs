using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine((int)input[i] - 97);
            }
        }
    }
}
