//Написать программу, которая обменивает элементы первой строки и последней строки

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

void ExchangeRow(int [,] ArrayToExchange)
{
    for (int row = 0; row < ArrayToExchange.GetLength(1) ; row++)
    {
      int buffer = ArrayToExchange[0, row];
      ArrayToExchange[0, row] = ArrayToExchange[ArrayToExchange.GetLength(0) - 1, row];
      ArrayToExchange[ArrayToExchange.GetLength(0) - 1, row] = buffer;
    }
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


int [,] TestArray = CreateIntegerArray(4, 5);
Show2DArray(TestArray, "Original");
ExchangeRow(TestArray);
Show2DArray(TestArray, "Changed");