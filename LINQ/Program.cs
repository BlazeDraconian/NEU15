using System.Net.Cache;

var objectlist = new List<object>();

objectlist.Add("Hello World");
objectlist.Add("This is a text");
objectlist.Add(5.3);
objectlist.Add("Hej");
objectlist.Add(true);
objectlist.Add(94);
objectlist.Add("a");
objectlist.Add("Bye!");

var StringList = new List<string>();
foreach (object item in objectlist)
{
    if (item is string s)
    {
        StringList.Add(s);
    }
}
Console.WriteLine("ObjectList :");
Console.WriteLine(string.Join('\n',objectlist));
Console.WriteLine();

//Oftype

var StringList2 = objectlist.OfType<string>().ToList();
Console.WriteLine("StringList :");
Console.WriteLine(string.Join('\n', StringList2));
Console.WriteLine();


StringList.Any();
Console.WriteLine($"StringList.Any() => {StringList.Any()}");
Console.WriteLine($"StringList.Any(StringList.Any(s => s.Length == 4)) => {StringList.Any(s => s.Length == 4)}");
Console.WriteLine($"StringList.All(StringList.Any(s => s.Length == 4)) => {StringList.All(s => s.Length == 4)}");
Console.WriteLine($"StringList.Any(s => s.Contains(\"ye\")) => {StringList.Any(s => s.Contains("ye"))}");
Console.WriteLine($"StringList.Any(s => s.ToLower()==\"Hej\")}} => {StringList.Any(s => s.ToLower()=="hej")}");


//List<Enemy> enemies = LevelElements.OfType<Enemy>().ToList();
//if (enemies.Any(e=> e.HP< 5)...



Console.WriteLine("\n*** Where ***\n");
var FilteredStrings = StringList.Where(s => s.Length <= 8).ToList();
Console.WriteLine("\nStringList.Where(s => s.Length <= 8).ToList();");
Console.WriteLine(string.Join('\n', FilteredStrings));
Console.WriteLine();


Console.WriteLine("\n*** Select ***\n");

var people = new[]
{
new{ FirstName = "Anders", LastName = "Svensson", Age = 34 },
new { FirstName = "Jonas", LastName = "Karlsson", Age = 22 },
new { FirstName = "Adam", LastName = "Andersson", Age = 12 },
new {FirstName = "Robert" , LastName = "Roberts" , Age= 34 }
}.ToList();

var people2 = people.Select(p => new {FullName = $"{p.FirstName} {p.LastName}", Age= p.Age}).ToList();
Console.WriteLine();

Console.WriteLine("\n*** OrderBy ***\n");
Console.WriteLine("people.OrderBy(p=> p.FirstName)) =>");
foreach (var p in people.OrderBy(p=> p.FirstName))
{
    Console.WriteLine(p);
}


var QuerySyntax = from p in people where p.Age > 30 select p.Age;
var MethodSyntax = people.Where(p => p.Age > 30).Select(p => p.Age);
Console.WriteLine();

foreach (var age in QuerySyntax)
{
    Console.WriteLine(age);
}

Console.WriteLine();
people.Add(new{ FirstName = "Adam",  LastName = "Andersson", Age = 12} );
foreach (var age in QuerySyntax)
{
    Console.WriteLine(age);
}