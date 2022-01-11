//задаем двухмерный массив и выводим его в консоль

void FillArray(int[,] array, int length) // заполняем двумерный массив рандомными значениями от -10 до 10
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}

void showArray (int[,] array, int length) // визуализируем массив в консоль
{
     for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
           Console.Write($"[{i}][{j}]:{array[i,j]} \t"); //выводим в консоль красиво оформленный массив
        }
        Console.WriteLine();
    }
}

const int matrixLenght = 5; // объявление двухмерной массив 5 на 5
int [,] twoDArray = new int [matrixLenght, matrixLenght]; //[,] - двумерный массив
FillArray(twoDArray, matrixLenght);
showArray(twoDArray, matrixLenght);