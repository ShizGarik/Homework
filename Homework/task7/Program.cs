//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

int number;

Console.Write("Введите число: ");
Int32.TryParse(Console.ReadLine(), out number);
  
switch (number)
{
   case 1: Console.WriteLine ("Понедельник");
   break;
   case 2: Console.WriteLine ("Вторник");
   break;
   case 3: Console.WriteLine ("Среда");
   break;
   case 4: Console.WriteLine ("Четверг");
   break;
   case 5: Console.WriteLine ("Пятница");
   break;
   case 6: Console.WriteLine ("Суббота");
   break;
   case 7: Console.WriteLine ("Воскресение");
   break;
   default: System.Console.WriteLine(number + " дня недели нет!");
   break;
}

if(number == 6 || number == 7)
{
    Console.WriteLine($"{number} день недели выходной день");
}