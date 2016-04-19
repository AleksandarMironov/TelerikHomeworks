using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();
            while (n!=0)
            {
                if (n%2 == 0)
                {
                    binary.Append("0");
                }
                else
                {
                    binary.Append("1");
                }
                n = n/2;
            }
            string output = binary.ToString();
            char[] test = output.ToCharArray();
            Array.Reverse(test);
            Console.WriteLine(test);
        }
    }
}
