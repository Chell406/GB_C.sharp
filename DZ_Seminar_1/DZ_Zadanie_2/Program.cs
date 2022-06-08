Console.WriteLine("Введите первое чило: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье чило: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;
if(max < num_2) max = num_2;
if(max < num_3) max = num_3;

Console.WriteLine($"Максимальное число: {max}");

// Вариант с вложенным ветвлением без применения промежуточной переменной
// if(num_1 > num_2)
//     if(num_1 < num_3)
//         Console.WriteLine($"{num_1} < {num_2}");
//     else
//         Console.WriteLine($"{num_1} > {num_2}");
// else
//     if(num_2 < num_3)
//         Console.WriteLine($"{num_1} < {num_2}");
//     else
//         Console.WriteLine($"{num_1} > {num_2}");