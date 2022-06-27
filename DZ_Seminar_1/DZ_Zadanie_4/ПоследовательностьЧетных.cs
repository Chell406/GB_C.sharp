Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Последовательность четных чисел от 1 до {N}: ");

/* Вариант с использованием цикла while
int index = 1;

while (index <= N)
{
    if (index % 2 == 0)
        Console.Write($"{index} ");

    index++;
}
*/

for (int index = 1; index <= N; index++)
{
    if (index % 2 == 0)
        Console.Write($"{index} ");
}