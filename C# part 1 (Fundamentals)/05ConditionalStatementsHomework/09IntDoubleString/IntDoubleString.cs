using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string inputType = Console.ReadLine();
            if (inputType == "integer")
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num+1);
            }

            if (inputType == "real")
            {
                double real = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", real+1);
            }

            if (inputType == "text")
            {
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
        }
    }
}
