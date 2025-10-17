using System.IO.Pipes;
using System.Net.Cache;
using System.Runtime.Intrinsics.X86;
/*
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
}*/


//# Övningsuppgifter med LINQ

//## 1. Anonyma datatyper
//Skapa en array "people" med anonyma datatyper. Varje objekt i arrayen ska ha följande properties: FirstName, LastName, Age, Height, Weight. 
//Lägg till minst 8 sådana objekt i arrayen. //Använd dig sedan av LINQ för att lösa följande uppgifter:

var people = new[]
{
    new {FirstName = "Dalinar", LastName = "Kholin", Age = 53 , Height = 186, Weight = 80},
    new {FirstName = "Kaladin", LastName = "Stormblessed", Age = 26, Height = 170, Weight = 72},
    new {FirstName = "Adolin", LastName = "Kholin", Age = 27, Height = 209, Weight = 92},
    new {FirstName = "Linda", LastName = "Mannheim", Age = 40, Height = 159, Weight = 89},
    new {FirstName = "Malfurion", LastName = "Stormrage", Age = 10500, Height = 236, Weight = 100},
    new {FirstName = "Baine", LastName = "Bloodhoof", Age = 36, Height = 250, Weight = 260},
    new {FirstName = "Aleria", LastName = "Windrunner", Age = 2000, Height =190, Weight =60},
    new {FirstName = "Greyson", LastName = "Reed", Age = 30, Height = 180, Weight = 75},
}.ToArray();

//## 2. Filtrera på ålder
//Filtrera arrayen(uppgift 1) så du får en ny lista med endast de användare som är mellan 20 och 40 år gamla. 
var PeopleAge = people.Where(person => person.Age >= 20 && person.Age <= 40).ToList();


//## 3. Är någon längre än 190 cm?
//Är någon av personerna mellan 20 och 40 år längre än 190 cm lång?

Console.WriteLine(PeopleAge.Any(person => person.Height > 1.90));


//## 4. Filtrera på namn
// Filtrera arrayen från uppgift 1 så att du får en ny lista med endast de användare vars förnamn är längre än efternamnet (d.v.s större antal bokstäver).
// I den nya listan vill vi att objekten ska ha endast properties FirstName och LastName.

var FilteredNames = people.Where(person => person.FirstName.Length > person.LastName.Length).Select(person => new { person.FirstName, person.LastName});
foreach (var p in FilteredNames)
{
    Console.WriteLine(p);
}

//## 5. Hela namnet tillsammans med BMI
//Skapa en ny lista från arrayen (från uppgift 1) som innehåller objekt med properties Name (hela namnet),
//samt BMI (uträknat från längd och vikt) för alla personer.
var BMI = people.Select(person => new { name = $"{person.FirstName} {person.LastName}", bmi = person.Weight / Math.Pow (person.Height / 100.0, 2) }).ToArray();
foreach (var p in BMI)
{
    Console.WriteLine($"Name : {p.name} BMI: {p.bmi:f1} ");
}



//## 6. Filtrera listan ovan på BMI
//Filtrera listan (från uppgift 5) så att du endast får med personer med BMI under 20 eller BMI över 25.
var FilteredBMI = BMI.Where(p => p.bmi < 20 || p.bmi > 25).ToArray();
foreach (var p in FilteredBMI)
{
    Console.WriteLine($"Name = : {p.name}. BMI = {p.bmi:f1}");
}

Console.WriteLine();

//## 7. Filtrera orginallistan på BMI
//Filtrera arrayen (från uppgift 1) så att du endast får med personer med BMI under 20 eller BMI över 25.
var filteredBMI = people
    .Where(person =>
    {
        var bmi = person.Weight / Math.Pow(person.Height / 100.0, 2);
        return bmi < 20 || bmi > 25;
    })
    .ToArray();
foreach (var p in filteredBMI)
{
    var bmi = p.Weight / Math.Pow(p.Height / 100.0, 2);
    Console.WriteLine($"Name = : {p.FirstName} {p.LastName}. BMI = : {bmi:f1} ");
}
Console.WriteLine();

//## 8. Username tillsammans med Category 
//Skapa en ny lista från arrayen (i uppgift 1) som innehåller objekt med properties Username (förnamnet + åldern, ex. “Kalle23”),
//samt Category (som har värdet “Child” eller “Adult” beroende på om personen är under 18 eller inte).
var agelist = people.Select(person => new { Username = $"{person.FirstName}{person.Age}", Category = person.Age < 18 ? "Child" : "Adult" }).ToList();
foreach (var p in agelist)
{
    Console.WriteLine($"Username = {p.Username}. Age category : {p.Category}");
}
Console.WriteLine();

//## 9. Query syntax
//Lös valfri uppgift query-syntax (om du använt method-syntax, annars tvärtom).
var filterednames = from p in people where p.FirstName.Length > p.LastName.Length select new {p.FirstName, p.LastName};

foreach (var p in filterednames)
{
    Console.WriteLine(p);
}
Console.WriteLine();
//## 10. Sortera efter längd
//LINQ använder metoderna .OrderBy() och .OrderByDescending() för att sortera data.
//Skriv ut alla personer (från uppgift 1) i längdordning (kortast först).
var HeightSorted = people.OrderBy(person => person.Height);
foreach (var p in HeightSorted)
{
    Console.WriteLine(p);
}
Console.WriteLine();

//## 11. Sortera äldst till yngst
//Skriv ut alla personer (från uppgift 1) sortera efter ålder; från äldst till yngst.
var AgeSorted = people.OrderByDescending(person =>  person.Age);
foreach (var p in AgeSorted)
{
    Console.WriteLine(p);
}
