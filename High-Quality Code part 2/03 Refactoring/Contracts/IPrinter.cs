using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    interface IPrinter
    {
        void Print(int matrixSize, int[,] matrix);
    }
}
