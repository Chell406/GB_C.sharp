double[] inputVector()
{
    double[] vector = new double[3];

    Console.WriteLine("Введите x :");
    vector[0] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите y :");
    vector[1] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите z :");
    vector[2] = Convert.ToDouble(Console.ReadLine());

    return vector;
}

void outputVector(double[] vector)
{
    if (vector.Length != 3)
    {
        Console.WriteLine($"Неверная длина вектора. Отображение невозможно.");
        return;
    }
    Console.WriteLine($"x: {vector[0]}; y: {vector[1]}; z: {vector[2]}");
}

double vectorDistance(double[] vector_1, double[] vector_2)
{
    if(vector_1.Length != vector_2.Length)
    {
        Console.WriteLine("Разная длина векторов. Вычисление расстояния невозможно.");
        return -1;
    }

    double distance;
    double distanceByDimension;
    double Temp = 0;

    for(int i = 0; i < vector_1.Length; i++)
    {
        distanceByDimension = Math.Abs(vector_1[i] - vector_2[i]); //вызывать Math.Abs() необязательно, т.к. далее будет возведение в квадрат
        
        Temp += Math.Pow(distanceByDimension, 2);
    }

    distance = Math.Sqrt(Temp);
    return distance;
}

// Пользовательский ввод через консоль
// Console.WriteLine("Ввод первого вектора");
// double[] firstVector = inputVector();
// Console.WriteLine("Ввод второго вектора");
// double[] secondVector = inputVector();

// Все значения положительные
// double[] firstVector = {3.0, 4.0, 5.0};
// double[] secondVector = {3.0, 2.0, 5.0};

// Все значения отрицательные
// double[] firstVector = {-3.0, -4.0, -5.0};
// double[] secondVector = {-3.0, -2.0, -5.0};

// Различные значения
double[] firstVector = {-3.0, -4.0, 5.0};
double[] secondVector = {3.0, -2.0, 5.0};

outputVector(firstVector);
outputVector(secondVector);

double vDistance;
vDistance = vectorDistance(firstVector, secondVector);
if(vDistance >= 0)
    Console.WriteLine(vDistance);