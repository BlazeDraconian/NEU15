using System.Text.Json;
using System.Text.Json.Serialization;


//var People = new person[]
//{
//   new person("Fredrik", "Anderson", 30, 170.3),
//    new person("Kalle", "Jonson",  25, 180.5),
//    new person("David", "Richards",  46, 160.3),
//};
//People[0].BestFriend = People[1];
//People[1].BestFriend = People[2];
//var options = new JsonSerializerOptions()
//{
//    WriteIndented = true,
//    IncludeFields = true,
//    IgnoreReadOnlyFields = true,
//    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
//    ReferenceHandler = ReferenceHandler.IgnoreCycles,
//};
//string json = JsonSerializer.Serialize(People, options);

//Console.WriteLine(json);




public class person
{
    public person(string firstName, string lastName, int age, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Height = height;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

    public person BestFriend { get; set; }

}