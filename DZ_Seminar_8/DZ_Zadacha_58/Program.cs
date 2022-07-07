
bool ProductOfArrays(int[,] firstArray, int[,] secondArray, int[,] productArray)
{
    if (firstArray.GetLength(1) != secondArray.GetLength(0))
    {
        Console.WriteLine("Перемножение данных матриц невозможно");
        return false;
    }

    for (int i = 0; i < productArray.GetLength(0); i++)
    {
        for (int j = 0; j < productArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                productArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return true;
}

int[,] array_1 = new int[2, 3];
MyArray.RandomFilling(array_1, 10);
Console.WriteLine("Исходный массив 1:");
MyArray.Show(array_1);

int[,] array_2 = new int[3, 2];
MyArray.RandomFilling(array_2, 10);
Console.WriteLine("Исходный массив 2:");
MyArray.Show(array_2);

int[,] productArray = new int[array_1.GetLength(0), array_2.GetLength(1)];
if(ProductOfArrays(array_1, array_2, productArray))
{
    Console.WriteLine("Результат перемножения:");
    MyArray.Show(productArray);
};

class MyArray
{
    public static void Show(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }
    }

    public static void Show(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"  {array[i]}");
        }
        Console.WriteLine();
    }

    // Заполнение массива рандомными целыми значениями от -max до max 
    public static void RandomFilling(int[,] array, int max)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = (new Random().Next(max) * 2) - max;
            }
        }
    }

    //Среднее арифметическое всех столбцов с округлением до 4 знаков
    public static double[] AverageOfColumns(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] averageValue = new double[columns];

        for (int i = 0; i < columns; i++)
        {
            double sumOfElementsInRows = 0;
            for (int j = 0; j < rows; j++)
            {
                sumOfElementsInRows += array[j, i];
            }
            averageValue[i] = Math.Round((sumOfElementsInRows / rows), 4);
        }

        return averageValue;
    }

    int SumOfElements(int[] array)
    {
        int sumOfElements = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumOfElements += array[i];
        }
        return sumOfElements;
    }

    public static void Show(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}  ");
            }
            Console.WriteLine();
        }
    }

    public static void Show(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"  {array[i]}");
        }
        Console.WriteLine();
    }

    //Заполнение массива дробными числами от -max до max
    //с округлением до 2 знаков после запятой
    public static void RandomFilling(double[,] array, int max)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round((((new Random().NextDouble()) * 2 * max) - max), 2);
            }
        }
    }

    //Среднее арифметическое всех столбцов с округлением до 4 знаков
    public static double[] AverageOfColumns(double[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] averageValue = new double[columns];

        for (int i = 0; i < columns; i++)
        {
            double sumOfElementsInRows = 0;
            for (int j = 0; j < rows; j++)
            {
                sumOfElementsInRows += array[j, i];
            }
            averageValue[i] = Math.Round((sumOfElementsInRows / rows), 4);
        }

        return averageValue;
    }
}