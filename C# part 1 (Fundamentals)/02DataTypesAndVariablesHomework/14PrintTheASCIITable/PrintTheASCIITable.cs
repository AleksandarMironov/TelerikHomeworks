using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char) i);
            }
        }
    }
}
