bool palindrome(int number)
{
    int Temp = number;
    int result = 0;
    while (true)
    {
        result += Temp % 10;
        Temp = (Temp - (Temp%10)) / 10;
        if (Temp > 0)
            result = result * 10;
        else
            break;
    }

    if (number == result)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int number;

// Ввод значения через консоль
// Console.Write("Введите число: ");
// number = Convert.ToInt32(Console.ReadLine());

number = 89012;

if(palindrome(number))
{
    Console.Write($"Число {number} палиндром");
}
else
{
    Console.Write($"Число {number} не палиндром");
}