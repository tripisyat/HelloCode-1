//Найти кубы чисел от 1 до N


Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < N; i++)
{
    double kub = Math.Pow(i, 3); // возведение в куб
    Console.WriteLine($"[{i}] = {kub} ");
}
    