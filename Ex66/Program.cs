//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m == n)
    Console.Write($"Сумма чисел от {m} до {n} равна нулю");
else if (n > m)
    Console.Write($"Сумма чисел от {m} до {n} равна {SumMN(m - 1, n)}");
else
    Console.Write($"Сумма чисел от {n} до {m} равна {SumMN(m, n - 1)}");

int SumMN(int m, int n)
{

    if (m == n)
        return 0;
    else if (n > m)
    {
        int result = m;
        m++;
        result = m + SumMN(m, n);
        return result;
    }
    else
    {
        int result = n;
        n++;
        result = n + SumMN(m, n);
        return result;
    }
}