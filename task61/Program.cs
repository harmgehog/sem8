// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольник


string centerText = "Отсюда стартует паскаля треугольник";
Console.Clear();

int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
int centerY = (Console.WindowHeight / 2) - 1;
Console.SetCursorPosition(centerX, centerY);
Console.Write(centerText);


/* код на питоне чтоб переписать в шарп

def pascal(xx):
    return [1]+[xx[i]+xx[i+1] for i in range(len(xx)-1)]+[1]
n, x = int(input()), [1]
for i in range(n): 
    print(*x, sep=' ')
    x=pascal(x) */