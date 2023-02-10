/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

public class MatrixClass
{
    public static int[,] FillSpireMatrix(int ROWS, int COLS)
    {
        int side = ROWS, m = COLS, dot = 0, axisY = 0, axisX = 0, fill = 0;
        int[,] matrix = new int[ROWS, COLS];                   // матрица
        while (fill < ROWS * COLS)
        {
            for (axisX = dot; axisX < m; matrix[axisY, axisX] = fill, fill++, axisX++)
                if (fill == ROWS * COLS) break;
            axisX--;
            for (axisY = dot + 1; axisY < side; matrix[axisY, axisX] = fill, fill++, axisY++)
                if (fill == ROWS * COLS) break;
            axisY--;
            for (axisX = m - 2; axisX >= dot; matrix[axisY, axisX] = fill, fill++, axisX--)
                if (fill == ROWS * COLS) break;
            axisX++;
            for (axisY = side - 2; axisY >= dot + 1; matrix[axisY, axisX] = fill, fill++, axisY--)
                if (fill == ROWS * COLS) break;
            dot++; side--; m--; axisY = dot;
        }
        return matrix;
    }
    static void ShowMatrix(int[,] mtx)
    {
        Console.Clear();
        int centerY = (Console.WindowHeight / 2) - ((mtx.GetLength(0)) / 2);
        int centerX = (Console.WindowWidth / 2) - ((mtx.GetLength(1) * 2) / 2);
        Console.WriteLine("\n\nВаш массив: ");
        Console.SetCursorPosition(centerX, centerY);
        for (int row = 0; row < mtx.GetLength(0); row++)
        {
            for (int col = 0; col < mtx.GetLength(1); col++)
            {
                Console.Write(" {0,2:00}", mtx[row, col]);
            }
            Console.WriteLine();
            Console.Write(string.Concat(Enumerable.Repeat(" ", (Console.WindowWidth / 2)
                - ((mtx.GetLength(1) * 2) / 2))));
        }
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
    }
    static void Main()
    {
        Console.Write("Количество строк массива: ");
        int ROWS = int.Parse(Console.ReadLine()!);          // строки и столбцы
        Console.Write("Количество столбцов массива: ");
        int COLS = int.Parse(Console.ReadLine()!);
        int[,] matrix = FillSpireMatrix(ROWS, COLS);
        ShowMatrix(matrix);
    }
}

/* public class MatrixClass2 // из центра назад
{
    static int[,] FillSpire(int[,] mtx, int first, int last, int count)
    {
        mtx[first, first] = count;
        for (int i = first; i < last; i++) mtx[first, i] = count--;
        for (int i = first; i < last; i++) mtx[i, last] = count--;
        for (int i = last; i > first; i--) mtx[last, i] = count--;
        for (int i = last; i > first; i--) mtx[i, first] = count--;
        return first + 1 < last ? FillSpire(mtx, first + 1, last - 1, count) : mtx;
    }
    static void Print(int[,] mtx, int max)
    {
        int w = max.ToString().Length + 1;
        for (int i = 0; i < mtx.GetLength(0); i++)
        {
            for (int j = 0; j < mtx.GetLength(1); j++)
            {
                string item = mtx[i, j] > max ? "" : mtx[i, j].ToString();
                Console.Write(item.PadLeft(w));
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Введите количество чисел для спирали: ");
            int NUM = int.Parse(Console.ReadLine()!);
            int side = (int)Math.Ceiling(Math.Sqrt(NUM));
            Print(FillSpire(new int[side, side], 0, side - 1, side * side), NUM);
        }
    }
} */