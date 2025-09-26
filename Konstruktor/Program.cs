
//Keyword new används för att skapa ett nytt objekt. ( en instans av en klass) 
person MyPerson = new person("Blaze", 26);

Console.WriteLine($"{MyPerson.name}");

Console.WriteLine();

Console.WriteLine($"{MyPerson.age}");

var me = new person("Alex" ,22);
//var andre = new("Andre", 44); //Fungerar inte. man kan inte använda var tillsammans med new()
class person
{
    public string name = string.Empty;
    public int age = 0 ;

    public person(string name, int age) // Konstruktor 
    {
        this.name = name;
        this.age = age;
    }
}