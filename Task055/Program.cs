// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] CreateIntegerArray(int rowsNumber, int colsNumber)
{
    int[,] arrayToReturn = new int[rowsNumber, colsNumber];
    for (int row = 0; row < rowsNumber; row++)
    {
        for (int col = 0; col < colsNumber; col++)
        {
            arrayToReturn[row, col] = new Random().Next(1, colsNumber);
        }
    }
    return arrayToReturn;
}

void Show2DArray(int[,] arrayToShow, string nameOfArray)
{
    System.Console.WriteLine($"Вывод массива {nameOfArray}");
    for (int row = 0; row < arrayToShow.GetLength(0); row++)
    {
        for (int col = 0; col < arrayToShow.GetLength(1); col++)
        {
            Console.Write($"[{row}][{col}]: {arrayToShow[row, col]} \t");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}
void ShowArray(double[] arrayToShow, string nameOfArray)
{
    System.Console.WriteLine($"Вывод массива {nameOfArray}");
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        Console.WriteLine($"[{i}]: {arrayToShow[i]} ");
    }
    System.Console.WriteLine();
}


double[] CalculateAverageOfColumns(int[,] arrayToCalculate)
{
    double[] calculatedAverageArray = new double[arrayToCalculate.GetLength(1)];
    for (int col = 0; col < arrayToCalculate.GetLength(1); col++)
    {
        calculatedAverageArray[col] = 0.0;
        for (int row = 0; row < arrayToCalculate.GetLength(0); row++)
        {
            calculatedAverageArray[col] += arrayToCalculate[row, col];
        }
        calculatedAverageArray[col] /= arrayToCalculate.GetLength(0);
    }
    return calculatedAverageArray;
}


int[,] arrayOfInt = CreateIntegerArray(6, 4);

Show2DArray(arrayOfInt, "Целочисленный");

double[] calculatedAverageArray = CalculateAverageOfColumns(arrayOfInt);

ShowArray(calculatedAverageArray,"Среднее арифметическое");