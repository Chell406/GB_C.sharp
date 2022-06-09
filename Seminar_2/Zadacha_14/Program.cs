Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 23 == 0) && (num % 7 == 0))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");