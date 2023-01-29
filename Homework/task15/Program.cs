// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sum = 0;

int Input(string message)
{
    System.Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out int error))  //Проверка. Если false то ошибка, если true продолжаем
    {
        return error;
    }
    Console.WriteLine("Вы ввели не число! Завершение работы.");
    return error;
}

int a = Input("Введите размер массива: ");

int[] arr = new int[a];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-9, 10);
    System.Console.Write(arr[i] + " | ");
}

for (int i = 0; i < arr.Length; i++)
{
    if (i == 0 || i % 2 != 0)
    {
        sum += arr[i];
    }
}
System.Console.Write($"\nСумма элементов, стоящих на нечётных позициях: {sum}");