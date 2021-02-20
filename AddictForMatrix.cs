using System;
using System.Collections.Generic;
using System.Text;

namespace ComplainMatrix
{
    public static class AddictForMatrix
    {
        public static int[,] AddictionMatrix(this int[,] matrixNumberOne, int[,] matrixNumberTwo)
        {
            int a = 0;
            int b = 0;

            int[,] addictionedMatrix = null;
            for (int i = 0; i < matrixNumberOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixNumberOne.GetLength(1); j++)
                {
                    if (matrixNumberOne[i, j] == null) matrixNumberOne[i, j] = 0;
                    if (matrixNumberTwo[i, j] == null) matrixNumberTwo[i, j] = 0;
                    if (i == j) addictionedMatrix[a, b] = matrixNumberOne[i, j] + matrixNumberTwo[i, j];
                }
            }
            return addictionedMatrix;
        }
    }
}
