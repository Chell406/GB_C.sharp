string input;
int number;

while (true) //бесконечный цикл проверки введенного значения
{
    Console.Write("Введите трехзначное число: ");

    input = Console.ReadLine();
    int.TryParse(input, out number);
    Console.WriteLine(number);
    
    if (number != 0)
    {
        if (number > -1000 && number < 1000) //если число трехзначное
        {
            break;
        }
    }

    Console.WriteLine("Веденно неверное значение.");
}

Console.WriteLine(input[2]);