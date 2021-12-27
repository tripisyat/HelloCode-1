//показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i*i <= N; i++)
{
    System.Console.Write($"[{i}] = {i*i},\t");// \t - табуляция
    if (i % 5 == 0)
    {
        Console.WriteLine();
    }
}