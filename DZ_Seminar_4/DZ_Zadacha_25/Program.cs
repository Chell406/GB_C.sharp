double myPow(double baseNum, int strenght)
{
    if (strenght < 0)
        return 0;
    if (strenght == 0)
        return 1.0;
    double result = baseNum;
    for (int i = 0; i <= strenght; i++)
    {
        result *= baseNum;
    }
    return result;
}

Console.WriteLine(myPow(456, -6));
Console.WriteLine(myPow(456, 0));
Console.WriteLine(myPow(-3, 3));
Console.WriteLine(myPow(3, 2));
Console.WriteLine(myPow(2, 5));
Console.WriteLine(myPow(0.5, 3));