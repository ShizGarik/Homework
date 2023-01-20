//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

    
    int number;

    do
    {
        Console.Write("Введите трехзначное число: ");
        Int32.TryParse(Console.ReadLine(), out number);

    }while (number < 100 || number > 1000);

    int twoNumber = number / 10;
    int oneNumber = twoNumber % 10;
    
    Console.WriteLine($"Вторая цифра числа: {oneNumber}");