 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number;

Console.Write("Введите число: ");
Int32.TryParse(Console.ReadLine(), out number);
    
if(number < 99)
{
    Console.WriteLine($"Третьего числа нет!");
}while(number > 999)
{
    number = number / 10;
}

number = number % 10;
Console.WriteLine($"{number}");