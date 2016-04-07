using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool answer = Math.Abs(a - b) <= eps;
            if (answer)
            {
                Console.WriteLine("true");
            }
            else
            {
            Console.WriteLine("false");
            } 
        }
    }
}
