void RandomFilling(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((((new Random().NextDouble()) * 20) - 10), 2);
        }
    }
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void ElementOfArray (double[,] array, int row, int column)
{
    int rowIndex = row - 1;
    int columnIndex = column - 1;

    if(rowIndex >= array.GetLength(0) 
        || columnIndex >= array.GetLength(1))
        Console.WriteLine($"Элемент в позиции (строка {row}, столбец {column}): не существует");
    else
        Console.WriteLine($"Элемент в позиции (строка {row}, столбец {column}): {array[rowIndex, columnIndex]}");
}

int rowAmount = 4, columnAmount = 6;   //значения заданы постоянными для примера. 

double[,] array = new double[rowAmount, columnAmount];

RandomFilling(array);
ShowArray(array);

int row = 2, column = 3; // порядковые номера строки и столбца
ElementOfArray(array, row, column);
row = 7; column = 6;
ElementOfArray(array, row, column);