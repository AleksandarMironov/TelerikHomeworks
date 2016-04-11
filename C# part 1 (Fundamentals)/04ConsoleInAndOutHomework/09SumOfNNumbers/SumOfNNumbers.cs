using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            long answer = 0;
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                answer = answer + num;
            }
            Console.WriteLine(answer);     
        }
    }
}
