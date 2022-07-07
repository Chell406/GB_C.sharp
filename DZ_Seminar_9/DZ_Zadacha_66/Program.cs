int SumOfNatural(int lowLim, int highLim)
{
    int sum = 0;
    if (lowLim != highLim + 1)
    {
        sum = SumOfNatural(lowLim + 1, highLim) + lowLim;
    }
    return sum;
}
void Natural(int lowLim, int highLim)
{
    if (lowLim != highLim + 1)
    {
        Console.Write($"{lowLim} ");
        Natural(lowLim + 1, highLim);
    }
}

int M = 2, N = 10;
Console.WriteLine($"Последовательность натуральных чисел от {M} до {N}: ");
Natural(M, N);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {SumOfNatural(M, N)}");