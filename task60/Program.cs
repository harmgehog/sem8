/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

public class MatrixClass
{
    public static int RowsI = 2, RowsJ = 2, RowsK = 2;          // 2x2x2
    public static int[,,] prlepipd = new int[RowsI, RowsJ, RowsK];

    public static int[,,] FillParallelepiped(int[,,] prlpd)
    {
        int[] temp = new int[90];
        for (int i = 10; i < 100; i++)                           // fill temp[XX]
            temp[i - 10] = i;

        for (int i = 0; i < temp.Length; i++)                   // shuffle
        {
            int j = new Random().Next(0, temp.Length);
            (temp[i], temp[j]) = (temp[j], temp[i]);
        }
        int counter = 0;
        for (int i = 0; i < prlpd.GetLength(0); i++)             // sampling
        {
            for (int j = 0; j < prlpd.GetLength(1); j++)
                for (int k = 0; k < prlpd.GetLength(2); counter++, k++)
                    prlpd[i, j, k] = temp[counter];
        }
        return prlpd;
    }

    static void ShowMatrix(int[,,] mtx)
    {
        for (int row = 0; row < mtx.GetLength(0); row++)
            for (int col = 0; col < mtx.GetLength(1); col++)
            {
                for (int lay = 0; lay < mtx.GetLength(2); lay++)
                    Console.Write(" {0,3}{1,7}", mtx[row, col, lay], $"({row},{col},{lay})");
                Console.WriteLine();
            }
    }
    
    static void Main()
    {
        ShowMatrix(FillParallelepiped(prlepipd));
    }
}