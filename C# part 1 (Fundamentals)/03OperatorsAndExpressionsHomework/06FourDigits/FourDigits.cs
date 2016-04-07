using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = int.Parse(number.ToString()[0].ToString());
            int b = int.Parse(number.ToString()[1].ToString());
            int c = int.Parse(number.ToString()[2].ToString());
            int d = int.Parse(number.ToString()[3].ToString());
            Console.WriteLine(a+b+c+d);
            Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);

        }
    }
}