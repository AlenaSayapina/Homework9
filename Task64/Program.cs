// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {m}, N = {n} ");

void PrintNum(int m, int n)
{
    if (n > m)
        for (int i = m; i <= n; i++)
            Console.Write($"{i} ");
    else
        for (int i = n; i <= m; i++)
            Console.Write($"{i} ");

}
PrintNum(m, n);

