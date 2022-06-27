Console.Write("Введите число N: ");

//int N = Convert.ToInt32(Console.ReadLine());

string input = Console.ReadLine();
int N;
int.TryParse(input, out N);

Console.WriteLine($"N = {N}");
Console.WriteLine("Последовательность целых чисел от -N до N:");
for (int i = -N; i <= N; i++)
    Console.Write($" {i}");