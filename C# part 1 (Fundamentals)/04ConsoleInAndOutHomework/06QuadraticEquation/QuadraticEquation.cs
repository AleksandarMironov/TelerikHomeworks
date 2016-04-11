using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                Console.WriteLine("{0:0.00}\n{1:0.00}", ((-b - Math.Sqrt(discriminant)) / (2 * a)), ((-b + Math.Sqrt(discriminant)) / (2 * a)));
              
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("{0:0.00}", -b/(2*a));
            }
            else if (discriminant <= 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
