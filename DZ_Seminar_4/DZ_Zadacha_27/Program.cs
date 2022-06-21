int sumOfDigits(int number)
{
    int digitsSum = 0;
    int Temp = Math.Abs(number);
    while(Temp != 0)
    {  
        digitsSum += Temp % 10;
        Temp /= 10;
    }

    return digitsSum;
}

int number = -30782109;
Console.WriteLine(sumOfDigits(number));