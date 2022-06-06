int day_num;

while (true)
{
    Console.Write("Введите номер дня недели: ");

    day_num = Convert.ToInt32(Console.ReadLine());

    if (day_num < 1 || day_num > 7)
    {
        Console.WriteLine($"Веденно неверное значение - {day_num}");
        continue;
    }

    break;
}

if (day_num == 1)
    Console.WriteLine($"День {day_num} - Понедельник");
if (day_num == 2)
    Console.WriteLine($"День {day_num} - Вторник");
if (day_num == 3)
    Console.WriteLine($"День {day_num} - Среда");
if (day_num == 4)
    Console.WriteLine($"День {day_num} - Четверг");
if (day_num == 5)
    Console.WriteLine($"День {day_num} - Пятница");
if (day_num == 6)
    Console.WriteLine($"День {day_num} - Суббота");
if (day_num == 7)
    Console.WriteLine($"День {day_num} - Восресенье");
