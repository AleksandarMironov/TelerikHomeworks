using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _16Trailing0InN
{
    class Trailing0InN
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count0 = 0;

            for (int i = 5; n/i >= 1; i *= 5)
            {
                count0 += n/i;
            }
            Console.WriteLine(count0);
        }
    }
}
