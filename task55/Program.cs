// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();

int[,] GenerateMatrix(int rows, int cols, int low, int up)
{
    int[,] mtx = new int[rows, cols];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            mtx[row, col] = new Random().Next(low, up + 1);
    return mtx;
    // mtx = Enumerable.Range(0, n).Select(r =>
    // Enumerable.Range(0, m).Select(c => new Random().Next(1, 99)).ToArray()).ToArray();
}
void Transpose(int[,] mtx, int n, int m)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = mtx[j, i];
    ShowMatrix(matrix);
}
void ShowMatrix(int[,] mtx)
{
    Console.WriteLine();
    for (int row = 0; row < mtx.GetLength(0); row++)
    {
        for (int col = 0; col < mtx.GetLength(1); col++)
            Console.Write(" {0,4}", mtx[row, col]);
        Console.WriteLine();
    }
}
int n = 5; //GetNum("Введите кол-во строк: ");
int m = 3; //GetNum("Введите кол-во столбцов: ");
int[,] matrix = GenerateMatrix(n, m, -100, 100);
// int[,] copyMtx = (int[,])mtx.Clone();
ShowMatrix(matrix);
Transpose(matrix, n, m);