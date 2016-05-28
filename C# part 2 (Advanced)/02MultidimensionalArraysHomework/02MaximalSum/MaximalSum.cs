using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string [] nM = input.Split(' ');
            int n = int.Parse(nM[0]);
            int m = int.Parse(nM[1]);
            int[][] mass = new int[n][];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                mass[i] = new int[m];
                string [] temp = input.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mass[i][j] = int.Parse(temp[j]);
                }
            }
            long maxSum = long.MinValue;
            long tempSum = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    tempSum = mass[i][j] + mass[i][j + 1] + mass[i][j + 2] +
                              mass[i + 1][j] + mass[i + 1][j + 1] + mass[i + 1][j + 2] +
                              mass[i + 2][j] + mass[i + 2][j + 1] + mass[i + 2][j + 2];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                    tempSum = 0;
                }
            }
            Console.WriteLine(maxSum);

        }
    }
}
