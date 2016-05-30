using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10NFactorial
{
    class NFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        private static BigInteger Factorial(BigInteger n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
