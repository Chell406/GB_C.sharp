int dayNum;

while(true)
{
    Console.WriteLine("Введите номер дня недели (от 1 до 7):");
    dayNum = Convert.ToInt32(Console.ReadLine());
    if((dayNum >= 1) && (dayNum<=7))
        break;
    else
        Console.WriteLine("Введено неверное значение. Ожидается число от 1 до 7 включительно.");
}

if (dayNum >= 1 && dayNum <= 5)
{
    Console.WriteLine("Будний");
}
else 
{
    Console.WriteLine("Выходной");
}