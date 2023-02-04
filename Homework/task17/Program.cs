// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Input(string message)
{
    int number;
    System.Console.Write(message);

    try
    {
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        System.Console.WriteLine("Не то");
        number = Input(message);
    }

    // number = number > 0 ? number : Input(message);
    return number;
}

int count = 0;

int a = Input("Введите размер массива: ");

int[] arr = new int[a];

for (int i = 0; i < arr.Length; i++) // цикл для ввода элемента массива
{
    System.Console.Write($"\n Введите элемент массива {i}: ");
    arr[i] = Input(" ");
}
Console.WriteLine("[{0}]", string.Join(", ", arr));

for (int i = 0; i < arr.Length; i++) // цикл для подсчета чисел больше нуля
{
    if (arr[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine("Чисел больше нуля: " + count);