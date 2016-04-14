using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BiggestOf5
{
    class BiggestOf5
    {
        //using only 5 if statements! (made it with 4 :D )
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if (b > a)
            {
                a = b;
            }
            if (c > a)
            {
                a = c;
            }
            if (d > a)
            {
                a = d;
            }
            if (e > a)
            {
                a = e;
            }
            Console.WriteLine(a);
        }
    }
}
