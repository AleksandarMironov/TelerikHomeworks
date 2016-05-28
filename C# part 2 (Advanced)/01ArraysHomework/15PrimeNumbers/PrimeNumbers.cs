using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 1; i--)
            {
                bool isPrime = true;
                for (int j = 2; j < Math.Sqrt(i); j++)
                {
                    if (i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
