// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int number = 10;
int[,] arr = new int[number, number];

int temp = 1;
int index = 0;
int count = 0;

while (temp <= arr.GetLength(0) * arr.GetLength(1))
{
    arr[index, count] = temp;
    temp++;
    if (index <= count + 1 && index + count < arr.GetLength(1) - 1)
        count++;
    else if (index < count && index + count >= arr.GetLength(0) - 1)
        index++;
    else if (index >= count && index + count > arr.GetLength(1) - 1)
        count--;
    else
        index--;
}

PrintArray(arr);

void PrintArray(int[,] array)
{
    for (int index = 0; index < array.GetLength(0); index++)
    {
        for (int count = 0; count < array.GetLength(1); count++)
        {
            if (array[index, count] / 10 <= 0)
            {
                Console.Write(String.Format("{0,5}", array[index, count]));
            }
            else
            {
                Console.Write(String.Format("{0,5}", array[index, count]));
            }
        }
        Console.WriteLine();
    }
}