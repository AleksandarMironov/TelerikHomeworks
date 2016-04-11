using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2*r*Math.PI;
            double area = r*r*Math.PI;
            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        }
    }
}
