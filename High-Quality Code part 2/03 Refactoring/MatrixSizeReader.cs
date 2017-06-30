using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class MatrixSizeReader:IMatrixSizeReader
    {
        public int Read()
        {
            Console.WriteLine("Enter a positive number for matix size between 1 - 99");
            string input = Console.ReadLine();
            int matrixSize;
            while (!int.TryParse(input, out matrixSize) || matrixSize < 0 || matrixSize > 100)
            {
                Console.WriteLine("Enter correct positive number! 1 - 99");
                input = Console.ReadLine();
            }
            return matrixSize;
        }
    }
}
