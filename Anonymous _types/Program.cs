
var person = new { FirstName = "Anders", LastName = "Svensson", Age = 34 };
Console.WriteLine(person.FirstName);
Console.WriteLine(person.LastName);
Console.WriteLine(person.Age);

var TypeExamples = new {Double = 5.4, Float = 3.2f, Decimal = 102.3, Bool = true};


var people = new[]
{
new{ FirstName = "Anders", LastName = "Svensson", Age = 34 },
new { FirstName = "Jonas", LastName = "Karlsson", Age = 22 },
new { FirstName = "Adam", LastName = "Andersson", Age = 12 },
};

foreach (var p in people)
{
    Console.WriteLine($"{p.FirstName} {p.LastName} är {p.Age} år gammal");
}

var user = new
{
    name = "Albin Nilsson",
    age = 45,
    contactInfo = new {email = "aaaaaaaaa@Gmail.com", phone = "01010101010101"}
};

Console.WriteLine(user);
