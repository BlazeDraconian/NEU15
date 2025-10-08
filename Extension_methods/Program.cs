using Library;

string text = "Good morning everyone";
Console.WriteLine(text.CountWords());

//Console.WriteLine(StringExtensions.CountWords(text));

//Samma sak men lättare syntax med (this) 
/*static class StringExtensions
{
    public static int CountWords(this string text)
    {
        return text.Split(' ').Length;
    }
}*/