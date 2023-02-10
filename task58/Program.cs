/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:       Результирующая матрица будет:
2 4 | 3 4                       18 20
3 2 | 3 3                       15 18       */

public class MatrixClass
{
    static int ROWS = 3; static int COLS = 2;       // строки и столбцы
    static int ROWS2 = 2; static int COLS2 = 3;
    static int minBond = 1; static int maxBond = 9; // пределы чисел
    static int[,] matrix1 = new int[ROWS, COLS];    // матрицы
    static int[,] matrix2 = new int[ROWS2, COLS2];
    static int[,] newMTX = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    static int[,] FillMatrix(int[,] mtx, int low, int up)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
            for (int col = 0; col < mtx.GetLength(1); col++)
                mtx[row, col] = new Random().Next(low, up + 1);
        return mtx;
    }
    public static int[,] MatrixMult(int[,] mtx1, int[,] mtx2)
    {
        if (mtx1.GetLength(1) != mtx2.GetLength(0))     // проверка для запуска извне
        {
            Console.WriteLine("Матрицы не совместимы и не могут быть перемножены!");
            return new int[mtx1.GetLength(0), mtx2.GetLength(1)];
        }
        else
        {
            int temp = 0;
            for (int i = 0; i < mtx1.GetLength(0); i++)
                for (int j = 0; j < mtx2.GetLength(1); j++)
                {
                    temp = 0;
                    for (int k = 0; k < mtx1.GetLength(1); k++)
                        temp += mtx1[i, k] * mtx2[k, j];
                    newMTX[i, j] = temp;
                }
            return newMTX;
        }
    }
    static void ShowMatrix(int[,] mtx)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
        {
            for (int col = 0; col < mtx.GetLength(1); col++)
                Console.Write(" {0,4}", mtx[row, col]);
            Console.WriteLine();
        }
    }
    static void Main()
    {
        matrix1 = FillMatrix(matrix1, minBond, maxBond);
        ShowMatrix(matrix1);
        Console.WriteLine();
        matrix2 = FillMatrix(matrix2, minBond, maxBond);
        ShowMatrix(matrix2);
        Console.WriteLine();
        newMTX = MatrixMult(matrix1, matrix2);
        ShowMatrix(newMTX);
    }
}