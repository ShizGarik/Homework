System.Console.WriteLine("Программа нахождения максимального из трех чисел");

System.Console.Write("Введите первое число: ");
int a = System.Convert.ToInt32( System.Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = System.Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите третье число: ");
int c = System.Convert.ToInt32(System.Console.ReadLine());

if(a > b && a > c)
{
    System.Console.WriteLine($"max {a}");
}else if (b > a && b > c)
{
   System.Console.WriteLine($"max {b}");
}else
{
    System.Console.WriteLine($"max {c}");
}