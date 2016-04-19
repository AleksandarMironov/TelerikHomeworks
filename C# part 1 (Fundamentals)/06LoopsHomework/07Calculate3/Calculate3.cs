using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07Calculate3
{
    class Calculate3
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
        static void Main()
        {
            //N! / (K! * (N - K)!)
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger answer = Factorial(n)/(Factorial(k)*Factorial(n - k));
            Console.WriteLine(answer);

        }
    }
}
