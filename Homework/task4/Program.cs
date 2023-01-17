int i = 1;

System.Console.WriteLine("Программа, показывает четные числа от 1 до N");

Console.Write("Введите четное число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (i <= a )
{
    if( i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }
    i++;
}