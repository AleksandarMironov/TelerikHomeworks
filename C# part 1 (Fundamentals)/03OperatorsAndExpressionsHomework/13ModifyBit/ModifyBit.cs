using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            ulong mask = 1;
            mask = mask << p;
            if (v == 0)
            {
                ulong answer = (n & (~mask));
                Console.WriteLine(answer);
            }
            if (v == 1)
            {
                ulong answer = (n | mask);
                Console.WriteLine(answer);
            }

        }
    }
}
