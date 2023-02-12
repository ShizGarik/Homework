// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Random rmd = new Random();

int m = rmd.Next(2, 3);
int n = rmd.Next(2, 3);

int[,] arr = new int[m, n];
int[,] myArr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rmd.Next(2, 6);
        System.Console.Write(arr[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = rmd.Next(2, 6);
        System.Console.Write(myArr[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int[,] result = new int[m, n]; // массив для результата произведения

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {  
        int sum = 0;
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            sum += arr[i, k] * myArr[k, j];
        }
        result[i,j] = sum;
        System.Console.Write(result[i,j] + "\t");
    }
    // System.Console.WriteLine(sum);
}
