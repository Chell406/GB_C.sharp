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

int difMinMax(int[] mas)
{
    int min = 0;
    int max = 0;
    int minMaxDif = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < min)
            min = mas[i];
        if (mas[i] > max)
            max = mas[i];
    }

    minMaxDif = max - min;

    return minMaxDif;
}

int[] massiv = newRandomMass(5); //новый массив на 5 элементов
outMass(massiv);
Console.WriteLine(difMinMax(massiv));