using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12N_thBit
{
    class N_thBit
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            long mask = 1;
            mask = mask << p;
            long answer = (n & mask) >> p;
            Console.WriteLine(answer);
        }
    }
}

//0

    //985276
    //49
