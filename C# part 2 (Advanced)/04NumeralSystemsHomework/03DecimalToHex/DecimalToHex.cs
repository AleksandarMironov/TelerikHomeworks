using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DecimalToHex
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string output = n.ToString("X");
            Console.WriteLine(output);
        }
    }
}
