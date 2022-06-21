int sumOfDigits(int number)
{
    int digitsSum;
    int Temp = number;
    while(Temp=!0)
    {  
        digitsSum = Temp % 10;
        Temp /= 10;
    }

    return digitsSum;
}