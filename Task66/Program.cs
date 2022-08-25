// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {m}, N = {n} ");


void PrintSumm(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N = {sum}");
        return;
    }
    sum = sum + (m++);
    PrintSumm(m, n, sum);
}

PrintSumm(m, n, 0);

