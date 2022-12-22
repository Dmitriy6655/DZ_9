// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Программа вычисления функции Аккермана.");

Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число m: ");
int  m = int.Parse(Console.ReadLine());


Console.Write($"Результат: {Recursion(n, m)}");

int Recursion(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Recursion(n - 1, 1);
    else
        return Recursion(n - 1, Recursion(n, m - 1));
}