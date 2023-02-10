// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//Составить частотный словарь двумерного массива

int Readint(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] FillArr(int m, int n, Random random)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1,10);
        }
    }

    return array;
}

Dictionary<int, int> fillDictionary(int[,] arr)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(!dict.ContainsKey(arr[i,j])) dict.Add(arr[i,j],1);
            else
            {
                dict[arr[i, j]]++;
            }
        }
    }

    return dict;
}

void printdict(Dictionary<int, int> dictionary)
{
    foreach (var VARIABLE in dictionary)
    {
        Console.WriteLine($"Число {VARIABLE.Key} содержится {VARIABLE.Value} раз");
    }
}

void PrintArr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int m,n = 0;
int[,] arr;
Dictionary<int, int> freqDict = new Dictionary<int, int>();
Random rnd = new Random();

m = Readint("Введите число m");
n = Readint("Введите число n");
arr = FillArr(m,n,rnd);

PrintArr(arr);
Console.WriteLine();
freqDict = fillDictionary(arr);
printdict(freqDict);