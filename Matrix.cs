using System;
using System.Collections.Generic;
using System.Text;

namespace SecondHomeTask
{
    public class Matrix
    {
        private int[,] matrix;
        private int size;
        public int Size { get; }
        public Matrix(params int[] diagonal)
        {
            size = diagonal.Length;
            Size = size;
            matrix = new int[diagonal.Length, diagonal.Length];
            for (int i = 0 ; i < diagonal.Length; i++)
            {
                for (int j = 0; j < diagonal.Length; j++)
                {
                    if (i == j) matrix[i,j] = diagonal[i];
                }
            }
            if (diagonal == null || diagonal.Length < 1) size = 0;
            else size = diagonal.Length;
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i > Size || j < 0 || j > Size) return 0;
                else return matrix[i, j];
            }
            set
            {
                if (i != j) matrix[i, j] = 0;
                else matrix[i, j] = value;
            }
        }
        public int Track ()
        {
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        result += matrix[i, j];
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += matrix[i, j] + " ";
                }
                result +="\n";
            }
            return result;
        }
        public bool Equals(int[,] firstMatrix, int[,] secondMatrix)
        {
            if (firstMatrix.Length != secondMatrix.Length) return false;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (firstMatrix[i, j] != secondMatrix[i, j]) return false;
                }
            }
            return true;
        }
       
    }
}
