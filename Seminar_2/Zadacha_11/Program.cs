int random_num = new Random().Next(100, 1000);

Console.WriteLine($"Сгенерированное число: {random_num}");

int result_num = ((random_num / 100) * 10) + (random_num % 10);

Console.WriteLine($"Результат: {result_num}");