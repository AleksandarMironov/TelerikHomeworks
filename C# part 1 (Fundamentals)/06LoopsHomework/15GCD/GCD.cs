using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _15GCD
{
    class GCD
    {
        static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputNums = input.Split(' ');
            BigInteger answer = Gcd(Math.Abs(int.Parse(inputNums[0])), Math.Abs(int.Parse(inputNums[1])));
            Console.WriteLine(answer);

        }
    }
}