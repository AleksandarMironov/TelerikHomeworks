using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class Printer : IPrinter
    {
        public void Print(int matrixSize, int[,] matrix)
        {
            for (int x = 0; x < matrixSize; x++)
            {
                for (int y = 0; y < matrixSize; y++)
                {
                    Console.Write($"{matrix[x, y],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
