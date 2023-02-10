/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
местамипервую и последнюю строку массива.
*/
using System;
using System.Collections.Generic;
using System.Linq;

public class Matrix
{
    public static int[,] GenerateFillMatrix(int[,] mtx, int low, int up)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
            for (int col = 0; col < mtx.GetLength(1); col++)
                mtx[row, col] = new Random().Next(low, up + 1);
        return mtx;
    }
    public static void ChangeRows(int[,] mtx, int n)
    {
        for (int i = 0; i < mtx.GetLength(1); i++)
            (mtx[n - 1, i], mtx[0, i]) = (mtx[0, i], mtx[n - 1, i]);
        Console.WriteLine();
        ShowMatrix(mtx);
    }
    public static void ShowMatrix(int[,] mtx)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
        {
            for (int col = 0; col < mtx.GetLength(1); col++)
                Console.Write(" {0,4}", mtx[row, col]);
            Console.WriteLine();
        }
    }
}
public class MainClass
{
    public static void Main()
    {
        int n = 5;
        int m = 3;
        int[,] matrix = new int[n, m];

        matrix = Matrix.GenerateFillMatrix(matrix, -100, 100);
        Matrix.ShowMatrix(matrix);
        Matrix.ChangeRows(matrix, n);
    }
}