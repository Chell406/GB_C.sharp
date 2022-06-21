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

Console.WriteLine(sumOfDigits(-30782109));
Console.WriteLine(sumOfDigits(30782109));
Console.WriteLine(sumOfDigits(46735528));