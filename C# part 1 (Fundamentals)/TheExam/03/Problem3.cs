using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Problem3
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            long sum = 0;
            
            for (int i = a; i <= b; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i%j == 0)
                    {
                        if (j % 2 ==1)
                        {
                            sum = sum + j;
                            
                        }

                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
