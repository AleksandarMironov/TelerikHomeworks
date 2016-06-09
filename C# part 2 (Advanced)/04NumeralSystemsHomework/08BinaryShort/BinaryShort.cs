using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            string output = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine(output);

            //Console.WriteLine(Convert.ToString(short.Parse(Console.ReadLine()), 2).PadLeft(16, '0'));
        }
    }
}



