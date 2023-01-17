System.Console.WriteLine("Программа нахождения максимального числа и наименьшего");

System.Console.Write("Введите первое число: ");
int a = System.Convert.ToInt32( System.Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = System.Convert.ToInt32(System.Console.ReadLine());

if(a > b)
{
    System.Console.WriteLine($"max {a} min {b}");
}else if (a == b)
{
   System.Console.WriteLine($"Число {a} и число {b} равны");
}else
{
    System.Console.WriteLine($"max {b} min {a}");
}