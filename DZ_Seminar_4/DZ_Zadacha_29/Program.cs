int[] newRandomMass(int masSize)
{
    int[] mas = new int[masSize];

    for (int i = 0; i < masSize; i++)
    {
        mas[i] = new Random().Next();
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
}

int size = 8;
int[] massiv = newRandomMass(size);
outMass(massiv);