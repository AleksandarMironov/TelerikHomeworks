using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int number = 2;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(number+i);
                }
                else
                {
                    Console.WriteLine((number + i)*-1);
                }
            }
        }
    }
}
