// зачем нужен return? Чтобы вернуть из функции что либо. 

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.WriteLine($"[{i}]:{arrayToShow[i]}");
    }
}

int [] fillArray(int size)
{
    int [] arrayToReturn = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayToReturn[i] = new Random().Next(-size, size);
    }
    return arrayToReturn;
}

int [] arrayOne = fillArray(5);
int [] arrayTwo = fillArray(10);

ShowArray(arrayOne);
ShowArray(arrayTwo);