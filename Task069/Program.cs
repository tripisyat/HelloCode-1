// Найти сумму элементов от M до N, N и M заданы
 
void showNaturalNumbers(long currentNumber, long number)
{
 if (currentNumber <= number) //если текущее число меньше заданного числа
 {
  Console.Write($" {currentNumber} ");
  showNaturalNumbers(currentNumber + 1, number);
 }
}
 
 
Console.WriteLine("Введите первое число: ");
long M = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long N = Convert.ToInt64(Console.ReadLine());
 
showNaturalNumbers(M, N);
Console.WriteLine();
 
long summ = (M + N) * (N - M + 1)/2;
Console.WriteLine($"Сумма чисел от {M} до {N} составляет: {summ}");