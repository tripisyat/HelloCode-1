// 65. Спирально заполнить двумерный массив:
//```
// 1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7 
//```

int[,] CreateSpiralArray(int rowLength, int colLength)
{
    int[,] arrayToReturn = new int[colLength, rowLength];
    int number = 0;
        int rightBorder = rowLength-1;
        int leftBorder = 0;
        int topBorder = 0;
        int bottomBorder = colLength-1;
        while (leftBorder <= rightBorder)
        {
            for (int j = leftBorder; j < rightBorder; j++)
            {
                arrayToReturn[leftBorder, j] = number;
                number++;
            }
            for (int j = topBorder; j < bottomBorder; j++)
            {
                arrayToReturn[j,rightBorder] = number;
                number++;
            }
            for (int j = rightBorder; j >= leftBorder; j--)
            {
                arrayToReturn[bottomBorder,j] = number;
                number++;
            }
            for (int j = bottomBorder-1; j > topBorder; j--)
            {
                arrayToReturn[j,leftBorder] = number;
                number++;
            }
            rightBorder--;
            leftBorder++;
            topBorder++;
            bottomBorder--;
        }
        
    
    return arrayToReturn;
}
void Show2DArray(int[,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.Write($"{arrayToShow[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] spiralArray = CreateSpiralArray(10,10);
Show2DArray(spiralArray);