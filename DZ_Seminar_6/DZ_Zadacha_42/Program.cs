int _10_to(int input, int osnovanie) {

	int ostatok;
	ostatok = input % osnovanie;
	int resultat;
	resultat = (input - ostatok) / osnovanie;
	if (resultat < osnovanie)
	{
		return (resultat * 10) + ostatok;
	}
	else
	{
		return (_10_to(resultat, osnovanie) * 10) + ostatok;
	}
}

Console.WriteLine("Введите число:");
int numberFromInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите основание:");
int osnovanie = Convert.ToInt32(Console.ReadLine());

int numberForOutput = _10_to(numberFromInput, osnovanie);
Console.WriteLine($"Число в {osnovanie} системе: {numberForOutput}");