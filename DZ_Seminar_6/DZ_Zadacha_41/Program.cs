int funcion()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int countOfZero = 0;
    int _continue = 0;

    if (number > 0)
        countOfZero++;

    while (true)
    {
        Console.WriteLine("Продолжить ввод?(1-да,0-нет)");
        _continue = Convert.ToInt32(Console.ReadLine());
        if (_continue == 0 || _continue == 1)
            break;
    }
    if (_continue == 1)
        return countOfZero + funcion();
    else
    {
        return countOfZero;
    }

}

Console.WriteLine($"Вы ввели число '0' {funcion()} раз");