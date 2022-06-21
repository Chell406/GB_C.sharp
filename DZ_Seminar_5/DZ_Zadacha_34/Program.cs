int[] newRandomMass(int masSize)
{
    int[] mas = new int[masSize];

    for (int i = 0; i < masSize; i++)
    {
        mas[i] = new Random().Next(100, 1000);
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

int positivCount(int[] mas)
{
    int countPositiv = 0;

    for (int i = 0; i < mas.Length; i++)
        if(mas[i] % 2 == 0)
            countPositiv++;
    
    return countPositiv;
}


int[] massiv = newRandomMass(5); //новый массив на 5 элементов
outMass(massiv);
Console.WriteLine(positivCount(massiv));
