// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Input(string message)
{
    System.Console.Write(message);

    if (!int.TryParse(Console.ReadLine(), out int error))  //Проверка. Если false то ошибка, если true продолжаем
    {
        Console.WriteLine("Вы ввели не число! Завершение работы.");
        return error;
    }
    return error;
}

int[] array = new int [8];

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    int a = Input("Введите число массива: ");
    array[i] = a;

    System.Console.WriteLine("[{0}]", string.Join(", ", array));
}
