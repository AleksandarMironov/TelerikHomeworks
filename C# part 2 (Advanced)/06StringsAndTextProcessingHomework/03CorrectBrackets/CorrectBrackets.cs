using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int open = 0;
            int close = 0;
            int tempStart = 0;
            int next = 0;
            while (tempStart < input.Length && next > -1)
            {
                next = input.IndexOf('(', tempStart);
                if (next > -1)
                {
                    open++;
                }
                tempStart = next + 1;
            }
            tempStart = 0;
            next = 0;
            while (tempStart < input.Length && next > -1)
            {
                next = input.IndexOf(')', tempStart);
                if (next > -1)
                {
                    close++;
                }
                tempStart = next + 1;
            }
            Console.WriteLine((open==close)? "Correct": "Incorrect");
        }
    }
}
