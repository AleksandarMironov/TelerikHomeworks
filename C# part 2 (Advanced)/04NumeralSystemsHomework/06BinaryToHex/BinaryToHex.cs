using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BinaryToHex
{
    class BinaryToHex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long temp = Convert.ToInt64(input, 2);
            string output = temp.ToString("X");
            Console.WriteLine(output);
        }
    }
}
