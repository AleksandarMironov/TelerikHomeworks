using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] fibMass = new long[51];
            fibMass[0] = 0;
            fibMass[1] = 1;
            long [] answer = new long[n];
            for (int i = 2; i <= 50; i++)
            {
                fibMass[i] = fibMass[i - 1] + fibMass[i - 2];
            }
            for (int i = 0; i < n; i++)
            {
                answer[i] = fibMass[i];
            } 
            Console.WriteLine(String.Join(", ", answer));
        }
    }
}
