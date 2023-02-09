// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Input(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Столбец --> ");

int n = Input("Строка --> ");

int[,] arr = new int[m, n];

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


Console.WriteLine("Среднее арифметическое каждого столбца");

for (int j = 0; j < arr.GetLength(1); j++)     // строки
{
    double sum = 0; // Обнуляю счетчик после подсчета слобца

    for (int i = 0; i < arr.GetLength(0); i++) // столбцы
    {
        sum += arr[i, j];
    }
    Console.Write($"{sum / m:f2} \t");
}
