using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NumbersComparer
{
    class NumbersComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double answer = (a > b) ? a : b;
            Console.WriteLine(answer);
        }
    }
}
