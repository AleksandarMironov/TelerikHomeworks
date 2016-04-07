using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong maskA = 1;
            ulong maskB = 1;
            for (int i = 0; i < 3; i++)
            {
                maskA = 1;
                maskB = 1;
                maskA = maskA << (3 + i);
                maskB = maskB << (24 + i);
                maskA = n & maskA;
                maskB = n & maskB;
                if ((maskA >> (3 + i)) == 0)
                {
                    maskA = 1;
                    maskA = maskA << (24+i);
                    n = n & (~maskA);
                }
                else
                {
                    n = n | (maskA << 21);
                }
                if ((maskB >> (24 + i)) == 0)
                {
                    maskB = 1;
                    maskB = maskB << (3+i);
                    n = n & (~maskB);
                }
                else
                {
                    n = n | (maskB >> 21);
                }

            }
            Console.WriteLine(n);


            //3, 4 and 5 with bits 24, 25 and 26
        }
    }
}






