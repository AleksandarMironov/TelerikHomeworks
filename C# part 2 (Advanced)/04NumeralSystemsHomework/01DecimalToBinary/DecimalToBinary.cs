using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            string output = Convert.ToString((long)n, 2);
            Console.WriteLine(output);
        }
    }
}
 