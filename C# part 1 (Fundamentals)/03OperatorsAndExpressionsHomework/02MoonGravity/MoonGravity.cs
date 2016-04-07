using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double answer = w * 0.17;
            Console.WriteLine("{0:0.000}", answer);
        }
    }
}
