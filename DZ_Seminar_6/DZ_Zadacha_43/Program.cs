double  k1, b1, k2, b2;
double x = 0, y = 0;

Console.WriteLine("Введите b1:");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
k2 = Convert.ToDouble(Console.ReadLine());

x = (b2 - b1) / (k1 - k2);
y = (k1 * x) + b1;

Console.WriteLine($"Лини пересекаются в точке ({x},{y})");