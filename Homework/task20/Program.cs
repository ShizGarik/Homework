// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MyArray(int[,] arr)
{
    Random rmd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rmd.Next(-10, 10);
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = Input("Столбец --> ");
int n = Input("Строка --> ");

int[,] arr = new int[m, n];

MyArray(arr);

Console.WriteLine("Поиск числа в массиве\n");

int element = Input("Введите число: ");

bool f = false;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == element)
        {
            f = true;
        }
    }
}

if (f)
{
    System.Console.WriteLine($"{element} -> такое число есть");
}
else
{
    System.Console.WriteLine($"{element} -> такого числа нет");
}
