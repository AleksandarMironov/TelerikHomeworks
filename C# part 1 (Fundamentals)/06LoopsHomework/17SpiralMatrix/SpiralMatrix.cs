using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17SpiralMatrix
{
    class SpiralMatrix
    {
        private static int[,] createSpiralMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            int row = 0, col = -1;
            int value = 1;

            bool horizontal = true;
            bool increasing = true;
            bool finish = false;

            while (!finish)
            {

                finish = true;
                if (horizontal && increasing)
                {
                    while (tryAndSet(matrix, row, col + 1, value, size))
                    {
                        finish = false;
                        col++;
                        value++;
                    }
                }
                else if (horizontal && !increasing)
                {
                    while (tryAndSet(matrix, row, col - 1, value, size))
                    {
                        finish = false;
                        col--;
                        value++;
                    }
                }
                else if (!horizontal && increasing)
                {
                    while (tryAndSet(matrix, row + 1, col, value, size))
                    {
                        finish = false;
                        row++;
                        value++;
                    }
                }
                else {
                    while (tryAndSet(matrix, row - 1, col, value, size))
                    {
                        finish = false;
                        row--;
                        value++;
                    }
                }

                if (!horizontal)
                {
                    increasing = !increasing;
                }
                horizontal = !horizontal;
            }

            return matrix;
        }


        private static bool tryAndSet(int[,] matrix, int row, int col, int value, int size)
        {
            if (row < 0 || col < 0 || row >= size || col >= size || matrix[row, col] != 0)
            {
                return false;
            }
            matrix[row, col] = value;
            return true;
        }

        private static void PrintMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        public static void Main(String[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[,] spiralMatrix = createSpiralMatrix(n);
            PrintMatrix(spiralMatrix, n);

        }
    }

}
