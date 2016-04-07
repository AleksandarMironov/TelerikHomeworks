using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("false");
            }
            else
            {
                int counter = 0;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
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
}
