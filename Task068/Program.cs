// Показать натуральные числа от M до N, N и M заданы

string ShowNumbers(int M, int N)
{
    if (M < N)
    {
        return $"{M} "+ ShowNumbers(M+1, N);
    }
    else if (M > N)
    {
        return $"{M} "+ ShowNumbers(M-1, N);     
    }
    else
    {
        return $"{M}";
    }
}
Console.WriteLine(ShowNumbers(25, 5));