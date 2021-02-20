using System;

namespace SecondHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix firstMatrix = new Matrix(3, 7, 8, 9, 33);
            Matrix secondMatrix = new Matrix(4, 6, 12, -5, 14, 2);
            firstMatrix.Track();
            Console.WriteLine(firstMatrix.ToString());
            //7.Создайте метод расширения для диагональной матрицы, выполняющий сложение двух диагональных матриц.Результат работы метода – новая диагональная матрица.Если размеры матрицы не совпадают – меньшая матрица дополняется нулями.
        }
    }
}
