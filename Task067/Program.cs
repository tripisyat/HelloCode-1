// Показать натуральные числа от N до 1, N задано
string ShowNumbers(int N)
{
    if (N > 1)
    {
        return $"{N} "+ ShowNumbers(N-1);
    }
    else 
    {
        return "1";
    }
}
Console.WriteLine(ShowNumbers(10));