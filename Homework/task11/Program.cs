// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int a = Input("Введите число: ");
int b = Input("Введите степень: ");

// double res = Math.Pow(a,b);

int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }

System.Console.WriteLine($"{a} в степени {b} равняется {res}");