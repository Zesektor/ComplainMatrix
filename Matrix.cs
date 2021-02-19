using System;
using System.Collections.Generic;
using System.Text;

namespace SecondHomeTask
{
    class Matrix
    {
        private int[,] matrix;
        public int Size { get; }
        public Matrix(params int[] diagonal)
        {
            matrix = new int[diagonal.Length, diagonal.Length];
            for (int i = 0 ; i < diagonal.Length; i++)
            {
                for (int j = 0; j < diagonal.Length; j++)
                {
                    if (i == j) matrix[i,j] = diagonal[i];
                }
            }
            if (diagonal == null || diagonal.Length < 1) Size = 0;
            else Size = diagonal.Length;
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
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
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
            return base.ToString();
        }
    }
}
