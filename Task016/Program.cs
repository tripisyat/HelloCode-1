// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели от 1 до 7");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 | dayNumber == 7)
{
    Console.WriteLine($"{dayNumber} - это выходной");
}
else if (dayNumber >=1 && dayNumber <= 5)
{
    Console.WriteLine($"{dayNumber} - это будний день");
}
else
{
    Console.WriteLine("Введено не верное значение дня недели");
}