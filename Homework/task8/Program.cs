// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number;

System.Console.Write("Введите пятизначное число: ");
Int32.TryParse(Console.ReadLine(), out number); // Не работает TryParse!!!!!!!!!!
string str = $"{number}"; // преобразовал целое число в строку

if (str[0] == str[4] && str[1] == str[3])
{
    System.Console.WriteLine($"{number} --> да");
}else
{
    System.Console.WriteLine($"{number} --> нет");
}