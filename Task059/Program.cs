// В прямоугольной матрице найти строку с наименьшей суммой элементов.
  
 
void FillTowDArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
  for (int j = 0; j < matr.GetLength(1); j++)
  {
   matr[i, j] = new Random().Next(0, 5);
  }
 }
}
 
void PrintTowDArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
  for (int j = 0; j < matr.GetLength(1); j++)
  {
   Console.Write($"[{i} {j}] {matr[i, j]} \t");
  }
  Console.WriteLine();
 }
}
 
void PrintArray(int[] array)//в качестве аргумента приходит массив
{
 int count = array.Length; //получение количество элементов в массиве
 
 for (int i = 0; i < count; i++) //пробегаем по всем элементам массива
 {
  Console.Write($"{array[i]} "); //выводим на экран элементы массива
 }
 Console.WriteLine();//пустая строка
}
 
int Min(int[] array)
{
 int min = array[0];
 int temp = 0;
 for (int i = 0; i < array.Length; i++)
 {
  if (array[i] < min)
  {
   min = array[i];
   temp = i;
  }
 }
 return temp;
 
}
 
int row = 4;
int col = 6;
int[,] twoDArray = new int[row, col];
FillTowDArray(twoDArray);
Console.WriteLine($"Дан массив: ");
PrintTowDArray(twoDArray);
 
int[] tempArray = new int[row];
 
for (int i = 0; i < twoDArray.GetLength(0); i++)
{
 for (int j = 0; j < twoDArray.GetLength(1); j++)
 {
  tempArray[i] += twoDArray[i, j];
 }
}
 
PrintArray(tempArray);
Min(tempArray);
Console.WriteLine(Min(tempArray));

