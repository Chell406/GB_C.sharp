
int row = 4, column = 6;

//double[,] array = new double[row, column]; // Работает и в double
int[,] array = new int[row, column];

// Заполнение массива рандомными значениями от -10 до 10 
MyArray.RandomFilling(array, 10);
MyArray.Show(array);

Console.WriteLine("Среднее арифметическое столбцов:");
MyArray.Show(MyArray.AverageOfColumns(array));

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