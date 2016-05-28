using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = double.Parse(Console.ReadLine());
            }
            double number = 0;
            int frequentTimes = 1;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                temp = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (mass[i] == mass[j])
                    {
                        temp++;
                    }
                }
                if (temp > frequentTimes)
                {
                    frequentTimes = temp;
                    number = mass[i];
                }
            }
            Console.WriteLine("{0} ({1} times)",number, frequentTimes);
        }
    }
}
