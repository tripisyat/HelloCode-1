// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void Create3dArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
               matrix[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}

int[] selectedNumbers = new int [89];
int GetNextRandomUnicNumber()
{
    int number = new Random().Next(10, 100);
    for (int i = 0; i < selectedNumbers.Length; i++)
    {
        if (selectedNumbers[i] == number)
        {
            return GetNextRandomUnicNumber();
        }
        else if (selectedNumbers[i] == 0)
        {
            selectedNumbers[i] == number;
            break;
        }
    }
    return number;
}

void Show3dArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i}][{j}][{k}]: {matrix[i, j, k]} \t");
            }
        }
    }
}

int[,,] thirdDArray = new int[5,5,5];
Create3dArray(thirdDArray);
Show3dArray(thirdDArray);
GetNextRandomUnicNumber();
Console.WriteLine();
Show3dArray(thirdDArray);