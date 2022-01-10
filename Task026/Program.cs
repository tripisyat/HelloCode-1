//Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result*A;
}
Console.WriteLine($"Ответ: {result}");