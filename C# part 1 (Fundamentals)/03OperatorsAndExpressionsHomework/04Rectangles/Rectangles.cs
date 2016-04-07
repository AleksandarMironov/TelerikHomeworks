using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2*width + 2*height;
            double area = width*height;
            Console.WriteLine("{1:0.00} {0:0.00}", perimeter, area);
        }
    }
}
