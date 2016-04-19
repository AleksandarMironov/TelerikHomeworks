using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DecimalToHex
{
    class DecimalToHex
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            string myHex = num.ToString("X");
            Console.WriteLine(myHex);
        }
    }
}
