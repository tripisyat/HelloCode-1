//задаем двухмерный массив и выводим его в консоль и перемножаем

void FillArray(int[,] array, int length) // заполняем двумерный массив рандомными значениями от -10 до 10
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int currentRand = new Random().Next(-10,10);
            array[i,j] =  (currentRand == 0) ? new Random().Next(1,10) : currentRand; // исключаем 0 из рандома. Т.е. если при строчке выше выпадет 0, то запускается новый рандом от 1 до 10
        }
    }
}

void showArray(int[,] array, int length) // визуализируем массив в консоль
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

int multiplyArray(int[,] array, int length) // метод перемножения двухмерного массива
{
    int multiply = 1;
     for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
           multiply *= array[i,j]; //перемножаем матрицу
        }        
    }
    return multiply;
}
const int matrixLenght = 5; // объявление двухмерного массив 5 на 5

int [,] twoDArray = new int [matrixLenght, matrixLenght]; //[,] - двумерный массив
FillArray(twoDArray, matrixLenght);
showArray(twoDArray, matrixLenght);
int result = multiplyArray(twoDArray, matrixLenght);
System.Console.WriteLine($"Произведение массива: {result}");