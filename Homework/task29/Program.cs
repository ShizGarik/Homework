// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 2;
int n = 3;

int Rec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Rec(m - 1, 1);
    }
    else
    {
        return (Rec(m - 1, Rec(m, n - 1)));
    }
}
System.Console.WriteLine(Rec(m, n));