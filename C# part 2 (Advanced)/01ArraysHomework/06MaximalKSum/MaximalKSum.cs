using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(mass);
            double score = 0;
            for (int i = mass.Length - 1; i > mass.Length - 1 - k; i--)
            {
                score = score + mass[i];
            }
            Console.WriteLine(score);
        }
    }
}
