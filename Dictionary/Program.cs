/*

var myDictionary = new Dictionary<string, string>();

myDictionary.Add("Boy", "Pojke");
myDictionary.Add("Girl" , "Flicka");
myDictionary.Add("Man", "Man");
myDictionary.Add("Woman" ,"Kvinna");

Console.WriteLine("Keys:");

foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
Console.WriteLine("\nValues");

foreach (var value in myDictionary.Values)
{
    Console.WriteLine(value);
}

Console.WriteLine("\nKeys with values");
foreach (var keyValuePair in myDictionary)
{
    Console.WriteLine($"The Key: {keyValuePair.Key} holds the value: {keyValuePair.Value}");
}
Console.WriteLine();
Console.WriteLine($"myDictionary[\"Girl\"] => {myDictionary["Girl"]}"); // Skriver ut "Flicka"

string input = Console.ReadLine();
do
{
    if (myDictionary.ContainsKey(input))
    {
        Console.WriteLine(myDictionary[input]);
    }

    else
    {
        Console.WriteLine("Nyckeln saknas");
    }

} while (input != string.Empty);

*/