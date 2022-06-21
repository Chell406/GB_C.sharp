int[] newRandomMass(int masSize)
{
    int[] mas = new int[masSize];

    for (int i = 0; i < masSize; i++)
    {
        mas[i] = new Random().Next(0, 1000);
        if (new Random().Next(0, 2) == 1)
            mas[i] = -mas[i];
    }
    return mas;
}

void outMass(int[] mas)
{
    int lenght = mas.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();
}

int negativePosSummary(int[] mas)
{
    int sumNegativePos = 0;
    for (int i = 1; i < mas.Length; i += 2)
    {
        sumNegativePos += mas[i];
    }
    return sumNegativePos;
}

int[] massiv = newRandomMass(5); //новый массив на 5 элементов
outMass(massiv);
Console.WriteLine(negativePosSummary(massiv));