//Показать натуральные числа от 1 до N, N задано

string ShowNumbers(int number, int N)
{
    if (number < N)
    {
        return $"{number} "+ ShowNumbers(number+1, N);
    }
    else 
    {
        return $"{N}";
    }
}
Console.WriteLine(ShowNumbers(1, 10));