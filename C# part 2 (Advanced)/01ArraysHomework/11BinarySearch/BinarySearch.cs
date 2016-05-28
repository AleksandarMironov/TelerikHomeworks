using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = double.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int mid = 0, first = 0, last = mass.Length - 1;

            bool found = false;

            //for a sorted array with ascending values
            while (!found && first <= last)
            {
                mid = (first + last) / 2;

                if (x == mass[mid])
                {
                    found = true;
                    break;
                }
                else
                {

                    if (x > mass[mid])
                    {
                        first = mid + 1;
                    }

                    if (x < mass[mid])
                    {
                        last = mid - 1;
                    }

                }

            }
            if (found)
            {
                Console.WriteLine(mid);
            }
            else
            {
                Console.WriteLine("-1");
            }

        }
    }
    
}
