// Составить частотный словарь элементов двумерного массива
int[,] CreateRandomArray(int rowLength, int colLength)
{
    int[,] arrayToReturn = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            arrayToReturn[i, j] = new Random().Next(0, rowLength * colLength);
        }
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
void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
      
        Console.WriteLine($"[{i}]:{arrayToShow[i]}");
    }
}
int[] CreateFrequencyArray(int[,] arrayOfNumbers)
{
    var frequencyRowArray = new int[arrayOfNumbers.GetLength(0) * arrayOfNumbers.GetLength(1)];
    for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
        {
            frequencyRowArray[arrayOfNumbers[i, j]] += 1;
        }
    }
    return frequencyRowArray;
}
int GetNumberOfNotNullItems(int[] frequencyRowArray)
{
    var numberOfNotNullItems = 0;
    for (int i = 0; i < frequencyRowArray.Length; i++)
    {
        if(frequencyRowArray[i] > 0)
        {
            numberOfNotNullItems+=1;
        }
    }
    return numberOfNotNullItems;
}
int[,] ClearOfNullFrequencyArray(int[] frequencyRowArray)
{
    int numberOfNotNullItems = GetNumberOfNotNullItems(frequencyRowArray);
    var frequencyArray = new int[numberOfNotNullItems, 2];
    int currentFrequencyArrayIndex = 0;
    for (int i = 0; i < frequencyRowArray.Length; i++)
    {
        if(frequencyRowArray[i] > 0)
        {
            frequencyArray[currentFrequencyArrayIndex,0] = i;
            frequencyArray[currentFrequencyArrayIndex,1] = frequencyRowArray[i];
            currentFrequencyArrayIndex++;
        }
    }
    return frequencyArray;
}
int rows = 5;
int cols = 6;
int[,] arrayOfNumbers = CreateRandomArray(rows, cols);
//Show2DArray(arrayOfNumbers);

int[] frequencyRowArray = CreateFrequencyArray(arrayOfNumbers);
ShowArray(frequencyRowArray);
int[,] frequencyArray = ClearOfNullFrequencyArray(frequencyRowArray);
Show2DArray(frequencyArray);