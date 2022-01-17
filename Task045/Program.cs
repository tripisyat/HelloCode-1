Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 
int firstNumber = 0;
int secondNumberPositiv = 1;
int secondNumberNegativ = 1;
int fibonacciPositiv = 0;
int fibonacciNegativ = 0;
 
Console.Write($"Ряд Фибоначчи для {number}: ");
 
for (int i = 0; i < number; i++) //для положительных чисел
{
 fibonacciPositiv = secondNumberPositiv;
 Console.Write("{0} ", fibonacciPositiv);
 fibonacciPositiv = firstNumber + secondNumberPositiv;
 firstNumber = secondNumberPositiv;
 secondNumberPositiv = fibonacciPositiv;
}
 
for (int i = number + 1; i <= 0; i++) //для отрицательных чисел
{
 fibonacciNegativ = secondNumberNegativ;
 Console.Write("{0} ", fibonacciNegativ);
 fibonacciNegativ = firstNumber - secondNumberNegativ;
 firstNumber = secondNumberNegativ;
 secondNumberNegativ = fibonacciNegativ;
}