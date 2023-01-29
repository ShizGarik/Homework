// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int count = 0;

int[] arr = new int[5];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
    System.Console.Write(arr[i] + " | ");
}

foreach (var item in arr)
{
    if (item % 2 == 0)
    {
        count++;
    }
}

System.Console.WriteLine($"\nКоличество чётных чисел в массиве: {count}");