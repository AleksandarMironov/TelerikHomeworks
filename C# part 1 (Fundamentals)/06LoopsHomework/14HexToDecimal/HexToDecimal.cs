using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long number  = Convert.ToInt64(input, 16);
            Console.WriteLine(number);
        }
    }
}
