//Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

void SortingOfRowArray(int[,] arrayToSorting)
{

}