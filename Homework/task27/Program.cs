﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 8;

int NaturRec(int number)
{
    if (number == 1)
    {
        return 1;
    }
    else
    {
        System.Console.Write(number + " ");
        return number = NaturRec(number - 1);
    }
}

System.Console.Write(NaturRec(number));