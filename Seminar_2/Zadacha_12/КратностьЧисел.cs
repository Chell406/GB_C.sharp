Console.Write("Введите число 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

int ost;
if (num_1 > num_2)
    ost = num_1 % num_2;
else
    ost = num_2 % num_1;

if (ost != 0)
    Console.WriteLine("Остаток от деления: " + ost);
else
    Console.WriteLine("Числа кратные");