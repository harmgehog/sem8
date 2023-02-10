/*      Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:     В итоге получается вот такой массив:
    1 4 7 2                     7 4 2 1
    5 9 2 3                     9 5 3 2
    8 4 2 4                     8 4 4 2                         */

public class MatrixClass
{
    static int ROWS = 4; static int COLS = 6; // строки и столбцы
    static int minBond = -100; static int maxBond = 100; // пределы чисел
    static int[,] matrix = new int[ROWS, COLS]; // матрица

    static int[,] FillMatrix(int[,] mtx, int low, int up)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
            for (int col = 0; col < mtx.GetLength(1); col++)
                mtx[row, col] = new Random().Next(low, up + 1);
        return mtx;
    }
    public static int[,] SortEachRow(int[,] mtx) // следуя рекомендации сделал метод не void
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
            for (int col = 0; col < mtx.GetLength(1); col++)
            {
                int max = col;
                for (int k = col + 1; k < mtx.GetLength(1); k++)
                    if (mtx[row, k] > mtx[row, max])
                        max = k;
                (mtx[row, col], mtx[row, max]) = (mtx[row, max], mtx[row, col]);
            }
        return mtx;
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
        int[,] matrix = new int[ROWS, COLS]; // матрица
        matrix = FillMatrix(matrix, minBond, maxBond);
        ShowMatrix(matrix);
        matrix = SortEachRow(matrix);
        Console.WriteLine("Матрица после сортировки строк по убыванию:");
        ShowMatrix(matrix);
    }
}
