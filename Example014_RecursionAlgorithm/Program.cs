string numberStr = Console.ReadLine() ?? "";
double numberFloat = Convert.ToDouble(numberStr.Replace('.',','));
int number = 3;
if ((int)numberFloat % number ==  0)
{
    Console.WriteLine($"Число {number} является целой степенью числа {number}");
}
else
{
    System.Console.WriteLine($"Число {number} не является целой степенью числа {number}");
    }