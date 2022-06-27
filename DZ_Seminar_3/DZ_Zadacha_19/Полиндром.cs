bool palindrome(int number)
{
    int Temp = number;
    int result = 0;
    while (Temp != 0)
    {
        result *= 10;
        result += Temp % 10;
        Temp /= 10;
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

number = -89098;

if(palindrome(number))
{
    Console.Write($"Число {number} палиндром");
}
else
{
    Console.Write($"Число {number} не палиндром");
}