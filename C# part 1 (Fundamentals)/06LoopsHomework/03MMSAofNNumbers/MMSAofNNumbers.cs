using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MMSAofNNumbers
{
    class MMSAofNNumbers
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            double min = num;
            double max = num;
            double sum = num;
            for (double i = 1; i < n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (min > num)
                {
                    min = num;
                }
                if (max < num)
                {
                    max = num;
                }
                sum = sum + num;

            }
            double avg = ((double)sum) / n;
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", avg);
           
        }
    }
}
