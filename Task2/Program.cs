// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Enter M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine());


Console.Write(Recursion(M, N));

int Recursion(int M, int N)
{
    if (M == N + 1) return 0;
    else return M + Recursion(M + 1, N);
}
