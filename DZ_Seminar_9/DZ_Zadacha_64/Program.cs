void Natural(int lowLim, int highLim)
{
    if (lowLim != highLim + 1)
    {
        Console.Write($"{lowLim} ");
        Natural(lowLim + 1, highLim);
    }
}

int M = 10, N = 23;
Console.WriteLine($"Последовательность натуральных чисел от {M} до {N}: ");
Natural(M, N);