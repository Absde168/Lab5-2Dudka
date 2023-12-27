Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
int count = CountDifferentCharacters(input); 
Console.WriteLine("Количество разных символов: " + count);
Console.ReadLine();
static int CountDifferentCharacters(string input)
{
    int count = 0; 

    foreach (char c in input)
    {
        if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c) && !char.IsSeparator(c)) 
        {
            count++;
        }
    }
    return count;
}
