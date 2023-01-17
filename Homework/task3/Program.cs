Console.WriteLine("Программа по проверке четности числа (делится ли оно на два без остатка)");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ( a % 2 == 0 )
{
    System.Console.WriteLine($"Число {a} четное и делится на два");
}else
{
    System.Console.WriteLine($"Число {a} является не четным");
}