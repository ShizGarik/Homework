Console.WriteLine("Программа нахождения максимального числа и наименьшего");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"max {a} min {b}");
}else if (a == b)
{
    Console.WriteLine($"Число {a} и число {b} равны");
}else
{
    Console.WriteLine($"max {b} min {a}");
}