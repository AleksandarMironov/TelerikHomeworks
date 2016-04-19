using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string binaryInput = Console.ReadLine();
            long output = Convert.ToInt64(binaryInput,2);
            Console.WriteLine(output);
        }
    }
}
