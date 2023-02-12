// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rmd = new Random();

int m = rmd.Next(4, 5);
int n = rmd.Next(4, 5);

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rmd.Next(-5, 6);
        System.Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int minSum = Int32.MaxValue; // максимальное значение Int32

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
    }
    System.Console.Write(sum + "\t");
}
System.Console.WriteLine("\n Наименьшая " + minSum + " ");
