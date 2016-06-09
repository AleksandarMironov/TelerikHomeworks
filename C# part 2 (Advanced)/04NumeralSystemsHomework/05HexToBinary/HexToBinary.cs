using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HexToBinary
{
    class HexToBinary
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long temp = long.Parse(input, System.Globalization.NumberStyles.HexNumber);
            string output = Convert.ToString(temp, 2);
            Console.WriteLine(output);
        }
    }
}
