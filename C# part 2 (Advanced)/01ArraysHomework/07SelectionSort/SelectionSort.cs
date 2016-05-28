using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                
      
                for (int j = i+1; j < n; j++)
                {
                    double temp = 0;
                    if (mass[i] > mass[j])
                    {
                        temp = mass[j];
                        mass[j] = mass[i];
                        mass[i] = temp;
                    }
                }
            }
            foreach (var el in mass)
            {
                Console.WriteLine(el);
            }
        }
    }
}
