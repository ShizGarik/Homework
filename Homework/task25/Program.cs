// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 i 2 i 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int i = Input("Размер массива X: ");
int j = Input("Размер массива Y: ");
int k = Input("Размер массива Z: ");

int[,,] arr = new int[i, j, k];

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

void CreateArray(int[,,] arr)
{
    Random rmd = new Random();

    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)]; // Вложил в один массив

    int number;

    for (int i = 0; i < temp.GetLength(0); i++) //Счетчик массива temp
    {
        temp[i] = rmd.Next(10, 100);
        number = temp[i];
        if (i >= 1) //Пропуск первого числа, для меньшего итераций
        {
            for (int j = 0; j < i; j++) // цикл для проверки одинаковых чисел
            {
                while (temp[i] == temp[j]) // проверка одинаковых чисел
                {
                    temp[i] = rmd.Next(10, 100);
                    j = 0; // обнуление счетчика
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }

    int count = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = temp[count]; // Присвоение чисел в трехмерный массив
                count++;
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"[{i} {j} {k}]");
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.Write($"{arr[i, j, k]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

CreateArray(arr);
PrintArray(arr);