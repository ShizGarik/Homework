// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

double b1 = Input("Введите b1: ");
double k1 = Input("Введите k1: ");
double b2 = Input("Введите b2: ");
double k2 = Input("Введите k2: ");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Прямые пересекутся в точке\nX: {x:f2} | Y: {y:f2}");
