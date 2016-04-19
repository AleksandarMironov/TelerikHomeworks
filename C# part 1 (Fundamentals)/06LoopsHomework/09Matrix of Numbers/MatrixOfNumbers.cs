using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int [,] matrix = new int[n,n];
            for (int i = 0, num = 1; i < n; i++, num ++)
            {
                for (int j = 0, print = num; j < n; j++, print++)
                {
                    Console.Write(print + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
