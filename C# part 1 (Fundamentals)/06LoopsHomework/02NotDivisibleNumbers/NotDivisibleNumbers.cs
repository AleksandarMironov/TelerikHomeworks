using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("1");
            for (int i = 2; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}
