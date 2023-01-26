//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
string str = a.ToString(); // конвертировал в строку

int res = 0;
for (int i = 0; i < str.Length; i++) // Пока i меньше длине строки то
{
    res = res + a % 10; // Прибавляю последнюю цифру к результату
    a /=10; // отделяю последню цифру
}

System.Console.WriteLine("Сумма цифр в числе: " + res);