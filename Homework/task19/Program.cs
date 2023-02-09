// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double genRndDouble(int a, int b)
{
    Random rnd = new Random();
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;
}

double[,] arr = new double[2, 3];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = genRndDouble(-10, 10);
        Console.Write($"{arr[i, j]:f2} \t");
        System.Console.Write("|");
    }
    Console.WriteLine();
}