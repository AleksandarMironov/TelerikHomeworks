using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = double.Parse(Console.ReadLine()); //trees
            double b = double.Parse(Console.ReadLine()); //branches
            double s = double.Parse(Console.ReadLine()); //squirrels on each branch.
            double n = double.Parse(Console.ReadLine()); //tales

            double answer = t * b * s * n;
            if (answer % 2 == 1)
            {
                answer = answer / 7.0;
                Console.WriteLine("{0:0.000}", answer);
            }
            else
            {
                answer = answer * 376439;
                Console.WriteLine("{0:0.000}", answer);
            }

        }
    }
}
