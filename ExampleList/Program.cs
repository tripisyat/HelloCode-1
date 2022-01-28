void showList(List<int> myList);
{
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }
}

void showDictionary(List<int> myList);
{
    foreach (var item in myList)
    {
        Console.WriteLine(item);
    }
}

List<int> numbers = new List<int>(); // объявляем список
numbers.Add(5);
numbers.AddRange(new List<int>{4, 5, 6, 7}); //
showList(numbers);

Dictionary<string, int> numberOfWords = new Dictionary<string, int>(); // Объявляем словарь, в него можно записывать по 2 значения в нашем случае string и int

string str = "11 222 333 111 555 777 555 777";
string[] words = str.Split(" ");
foreach (string word item in words)
{
    if (numberOfWords.ContainsKey(word) // проверяет есть ли это значение в словаре
    {
        numberOfWords[word] = 1;
    }
    else
    {
        numberOfWords[word] = ++;
    }
}

showDictionary(numberOfWords);
