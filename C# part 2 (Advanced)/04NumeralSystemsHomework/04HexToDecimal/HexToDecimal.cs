using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HexToDecimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long output = long.Parse(input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(output);
        }
    }
}
