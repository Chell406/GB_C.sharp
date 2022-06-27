Console.Write("Введите число 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

// if (num_1 > num_2)
//     if (num_2 * num_2 == num_1)
//         Console.WriteLine("Да");
//     else
//         Console.WriteLine("Нет");
// else
//     if (num_2 == Math.Pow(num_1,2))
//         Console.WriteLine("Да");
//     else
//         Console.WriteLine("Нет");

if ((num_2 * num_2 == num_1) || (num_2 == Math.Pow(num_1,2)))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");