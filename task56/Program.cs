/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

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
    public static int MinSumRow(int[,] mtx)
    {
        int minI = 0; int temp = int.MaxValue;
        for (int row = 0; row < mtx.GetLength(0); row++)
        {
            int sum = 0;
            for (int col = 0; col < mtx.GetLength(1); sum += mtx[row, col], col++)
                if (temp > sum) (temp, minI) = (sum, row);
        }
        return minI + 1;
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
        matrix = FillMatrix(matrix, minBond, maxBond);
        ShowMatrix(matrix);

        Console.WriteLine($@"
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов:
                                             {MinSumRow(matrix)}-я строка.
                                             
                                             ");
    }
}