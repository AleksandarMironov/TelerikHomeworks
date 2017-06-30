using System;
using System.ComponentModel;

namespace Matrix
{
    class WalkInMatrix
    {
        static void ChangeDirection(ref int directionX, ref int directionY) // change direction of rotation
        {
            int[] dirX = {1, 1, 1, 0, -1, -1, -1, 0};
            int[] dirY = {1, 0, -1, -1, -1, 0, 1, 1};
            int checkedDirections = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == directionX && dirY[count] == directionY)
                {
                    checkedDirections = count;
                    break;
                }
            }

            if (checkedDirections == 7) //all directions are checked, refresh to first state
            {
                directionX = dirX[0];
                directionY = dirY[0];
                return;
            }

            directionX = dirX[checkedDirections + 1];
            directionY = dirY[checkedDirections + 1];
        }

        static bool CheckForEmptyCells(int[,] arr, int x, int y)
        {
            int[] directionsX = {1, 1, 1, 0, -1, -1, -1, 0};
            int[] directionsY = {1, 0, -1, -1, -1, 0, 1, 1};

            int arrLenght = arr.GetLength(0);

            for (int i = 0; i < 8; i++)
            {
                int xForCheck = x + directionsX[i];
                int yForCheck = y + directionsY[i];

                if (xForCheck >= arrLenght || x + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }
                if (yForCheck >= arrLenght || y + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                int xForCheck = x + directionsX[i];
                int yForCheck = y + directionsY[i];
                if (arr[xForCheck, yForCheck] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindNextEmptyPartOfTheMatrix(int[,] arr, out int x, out int y)
            //return first cell of second free triangle of the matrix
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        static void FillTheMatrix(ref int numberInCell, ref int positionX, ref int positionY, int directionX, int directionY, ref int [,] matrix)
        {
            int matrixSize = matrix.GetLength(0);
            while (true) // fill first part of matrix
            {
                matrix[positionX, positionY] = numberInCell;

                if (!CheckForEmptyCells(matrix, positionX, positionY)) // check: is there any empty cells left
                {
                    break;
                }

                if (positionX + directionX >= matrixSize || positionX + directionX < 0 || positionY + directionY >= matrixSize || positionY + directionY < 0 || matrix[positionX + directionX, positionY + directionY] != 0)
                {
                    while ((positionX + directionX >= matrixSize || positionX + directionX < 0 || positionY + directionY >= matrixSize || positionY + directionY < 0 || matrix[positionX + directionX, positionY + directionY] != 0))
                    {
                        ChangeDirection(ref directionX, ref directionY);
                    }
                }
                positionX += directionX;
                positionY += directionY;
                numberInCell++;
            }
        }
        static void Main()
        {
            var matrixSizeReader = new MatrixSizeReader();
            int matrixSize = matrixSizeReader.Read();

            int[,] matrix = new int[matrixSize, matrixSize];

            int numberInCell = 1,  //firs number
                positionX = 0,
                positionY = 0,
                directionX = 1,
                directionY = 1;

            FillTheMatrix(ref numberInCell, ref positionX, ref positionY, directionX, directionY, ref matrix);
 
            FindNextEmptyPartOfTheMatrix(matrix, out positionX, out positionY);

            if (positionX != 0 && positionY != 0) //check is there second triangle to fill 
            {
                directionX = 1;
                directionY = 1;
                numberInCell++;

                FillTheMatrix(ref numberInCell, ref positionX, ref positionY, directionX, directionY, ref matrix);
            }

            var printer = new Printer();
            printer.Print(matrixSize, matrix);
        }
    }
}
