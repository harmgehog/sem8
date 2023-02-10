
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;

// генерация массива
int[] FillArray(int size, int minEdge, int maxEdge)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minEdge, maxEdge + 1);
    Console.Write("Your new array: ");
    ShowArray(arr);
    return arr;
}

static void ShowArray(int[] arr)
{
    foreach (int i in arr) Console.Write(String.Format(" {0,3}", i));
    Console.Write('\n');
}

// и последний метод - перемешивание массива
static void Shuffle(int[] arr)
{
    for (int a = arr.Length - 1; a >= 0; a--)
    {
    int b = new Random().Next(a);
    (arr[a], arr[b]) = (arr[b], arr[a]);
    }
    Console.Write("A shuffled arr: ");
    ShowArray(arr);
}
// вывод в консоль количества четных
static void CountOfEvens(int[] arr)
{
    int evens = 0; for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) evens++;
    Console.Write("Count of evens:   ");
    Console.WriteLine(evens);
}

// вывод в консоль суммы каждого нечетного
static void SumOfOdds(int[] arr)
{
    int odds = 0; for (int i = 0; i < arr.Length; odds += arr[i], i += 2) ;
    Console.Write("Summ of val by odd indices:   ");
    Console.WriteLine(odds);
}

// вывод в консоль max & min
static void MaxMin(int[] arr)
{
    // Console.Write($"Max is: {arr.Max()} Min is: {arr.Min()} "); 
    int max = arr[0]; int min = arr[0];
    foreach (int a in arr) if (a > max) max = a; else if (a < min) min = a;
    Console.Write($"Max value is: {max}\nMin value is: {min}\n");
}

// перемножение крайних пар к центру
static void MultEdges(int[] arr)
{
    int size = arr.Length - 1;
    bool flag = size % 2 == 0;
    Console.Write("Products of ev: ");
    for (int i = 0; i < size; i++, size--)
    {
        Console.Write(String.Format(" {0,3}", arr[i] * arr[size]));
    }
    if (flag) Console.WriteLine(String.Format(" {0,3}", arr[arr.Length / 2 + 1])); 
    else Console.WriteLine(" ");
}

// инвертирование самого массива
static void InvertArray(int[] arr)
{
    int size = arr.Length - 1;
    for (int i = 0; i < size; i++, size--) (arr[i], arr[size]) = (arr[size], arr[i]);
    Console.Write("Inverted array: ");
    ShowArray(arr);
}

// сортировка массива
static void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++) if (arr[j] < arr[min]) min = j;
        (arr[i], arr[min]) = (arr[min], arr[i]);
    }
    Console.Write("A sorted array: ");
    ShowArray(arr);
}

// метод нахождения заданного числа в массиве
static void FindVallueArray(int[] arr, int value)
{
    string result = "out of the Array";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == value)
        {
            result = "in the Array"; break;
        }
    }
    Console.WriteLine($"Value {value} {result}");
}

// метод инверсии значений массива
static void InverseNumsArray(int[] arr)
{
    for (int i = 0; i < arr.Length; arr[i] = -arr[i], i++) ;
    Console.Write("Inverted vals in: ");
    ShowArray(arr);
}

// метод подсчета суммы плюсов и минусов
static void SumPMArray(int[] arr)
{
    int sumP = 0; int sumM = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumP += arr[i];
        if (arr[i] < 0) sumM += arr[i];
    }
    Console.Write($"Summ of pluses:    {sumP}\nSumm o'minuses:   {sumM}\n");
}

// получение данных от консоли
int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// основной цикл
int[] NewArray()
{
    int size = GetNum(" Input size of array: ");
    int minEdge = GetNum("Input min edge array: ");
    int maxEdge = GetNum("Input max edge array: ");
    int[] arr = FillArray(size, minEdge, maxEdge);
    return arr;
}
int[] arr = NewArray();
static void Help()
{
    Console.WriteLine("\nСhoose digit of action, where:\n\n0 or 'stop' - to 'STOP' or break the program\n\n1 - Invert Numbers in Array\n2 - Sort of Array\n3 - Reverse Array\n4 - Product of Extreme values\n5 - Find exact value in Array\n6 - Write Sum of pluses & sum of minuses\n7 - Show Max&min\n8 - Show Sum of values by odd indicies\n9 - Show count of evens\n10 - to shuffle array\n11 or 'new' - to create a new Array\n12 or any input - renew script & show this HELP\n");
}
Help();

// вызовы всех методов для будущего калькулятора
while (true)
{
    string input = Console.ReadLine()!;
    if (input == "0" || input == "stop" || input == "break") break;
    else if (input == "new" || input == "11")
    {
        arr = NewArray();
    }
    else if (input == "1") InverseNumsArray(arr);
    else if (input == "2") SortArray(arr);
    else if (input == "3") InvertArray(arr);
    else if (input == "4") MultEdges(arr);
    else if (input == "5")
    {
        int value = GetNum("Input value to search in: ");
        FindVallueArray(arr, value);
    }
    else if (input == "6") SumPMArray(arr);
    else if (input == "7") MaxMin(arr);
    else if (input == "8") SumOfOdds(arr);
    else if (input == "9") CountOfEvens(arr);
    else if (input == "10") Shuffle(arr);
    else Help(); continue;
}
