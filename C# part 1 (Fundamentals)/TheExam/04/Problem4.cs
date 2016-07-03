using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Problem4
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int number = 1 + (s-10)/4;
            Console.WriteLine(" " + ch + new string(' ', number) + ch);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(" " + new string (ch, number+2));
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("  " + new string(ch, number));
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(" " + new string(ch, number + 2));
            }
            Console.WriteLine(" " + new string (ch, number+2) + "   " + new string (ch, number+1));
            for (int i = 0; i < number +2; i++)
            {
                Console.WriteLine(new string(ch, number + 4) + "  " + ch);
            }
            Console.WriteLine(new string(ch, number + 4) + " " + ch + ch);
            Console.WriteLine(" " + new string(ch, number + 5));
        }
    }
}
