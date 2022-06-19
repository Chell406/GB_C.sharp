int input()
{
    int number;
    while (true)
    {
        Console.WriteLine("Введите число");
        number = Convert.ToInt32(Console.ReadLine());
        if (number >= 1)
            break;
        else
            Console.WriteLine("Ведено неверное значение");
    }
    return number;
}

void tableOfCubes(int limit, int columns)
{
    for (int i = 1; i <= limit; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.Write($"{cube} ");
        if (i % columns == 0)
            Console.WriteLine();
    }
}

int N;
N = input();
Console.WriteLine($"Таблица кубов от 1 до {N}:");
tableOfCubes(N, N);
Console.WriteLine();
tableOfCubes(3, 2);
Console.WriteLine();
tableOfCubes(10, 5);
Console.WriteLine();
tableOfCubes(21, 7);
Console.WriteLine();
tableOfCubes(100, 5);