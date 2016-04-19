using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08CatalanNumbers
{
    class CatalanNumbers
    {
        static BigInteger Factorial(int number)
        {
            BigInteger fac = 1;
            for (int i = 1; i <= number; i++)
            {
                fac = fac * i;
            }
            return fac;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger answer = Factorial(2*n)/(Factorial(n + 1)*Factorial(n));
            Console.WriteLine(answer);
        }
    }
}
