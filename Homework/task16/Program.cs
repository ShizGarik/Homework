// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double difference;

double[] arr = new double[5];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.NextDouble() + rnd.Next(0, 10);
    System.Console.Write($"{arr[i]:f2} | ");
}

System.Console.WriteLine();

double min = arr[0];
double max = arr[0];

foreach (var item in arr)
{  
    if(max < item)
    {
        max = item;
    }
    if(min > item)
    {
        min = item;
    }
}
System.Console.WriteLine($"\nМинимальное число массива: {min:f2}");
System.Console.WriteLine($"Максимальное число массива: {max:f2}");

difference = max - min;

System.Console.WriteLine($"\nРазница между {min:f2} и {max:f2} равна {difference:f2}");