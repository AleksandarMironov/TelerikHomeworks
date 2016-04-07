using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113rdBit
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << 3;
            int answer = (n & mask) >> 3;
            Console.WriteLine(answer);
        }
    }
}
