using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long maskA = 1;
            long maskB = 1;

            //{p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}

            for (int i = 0; i < k; i++)
            {
                maskA = 1;
                maskB = 1;
                maskA = maskA << (p + i);
                maskB = maskB << (q + i);
                maskA = n & maskA;
                maskB = n & maskB;
                if (maskA  == 0)
                {
                    maskA = 1;
                    maskA = maskA << (q + i);
                    n = n & (~maskA);
                }
                else
                {
                    maskA = 1 << (q + i);
                    n = n | maskA;
                }

                if (maskB == 0)
                {
                    maskB = 1;
                    maskB = maskB << (p + i);
                    n = n & (~maskB);
                }
                else
                {
                    maskB = 1 << (p + i);
                    n = n | maskB;
                }

            }
            Console.WriteLine(n);


        }
    }
}
