using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06CalculateAgain
{
    class CalculateAgain
    {
        static BigInteger Factorial(int number)
        {
            BigInteger fac = 1;
            for (long i = 1; i <= number; i++)
            {
                fac = fac * i;
            }
            return fac;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            BigInteger answer = Factorial(n)/Factorial(x);
            Console.WriteLine(answer);

        }
    }
}
