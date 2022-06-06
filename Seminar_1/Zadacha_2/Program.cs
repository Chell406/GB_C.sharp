int day_num;

Console.Write("Введите номер дня недели: ");

day_num = Cosole.Readline();

if (day_num < 1 || day_num > 7)
    Console.WriteLine("Веденно неверное значение");

if (day_num == 1)
    Console.WriteLine("Понедельник");
if (day_num == 2)
    Console.WriteLine("Вторник");
if (day_num == 3)
    Console.WriteLine("Среда");
if (day_num == 4)
    Console.WriteLine("Четверг");
if (day_num == 5)
    Console.WriteLine("Пятница");
if (day_num == 6)
    Console.WriteLine("Суббота");
if (day_num == 7)
    Console.WriteLine("Восресенье");
