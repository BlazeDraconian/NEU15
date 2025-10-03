var countries = new List<string>() {"Sweden" , "Denmark" , "Norway" };
countries.Add("Finland");
countries.Add("Iceland");

Console.WriteLine($"number of countries in list {countries.Count}");

//countries.Clear(); Removes all elements
//countries.Remove("Norway");
countries.Remove("Spain"); //returns false 
//countries.RemoveAt(2); //Removes Finland cause Norway has already been removes 
//Console.WriteLine(countries[0]);
//countries.RemoveRange(0, 3); //Removes from index 0 and 3 forward

foreach (var country in countries)
{
    Console.WriteLine(country);
}

var myCountry = "Sweden";
Console.WriteLine($"countries.contains(\"{myCountry}\") == { countries.Contains(myCountry)}");
Console.WriteLine($"countries.Capacity => {countries.Capacity}"); //Allocated memory for the list

countries.Clear();
var numbers = new List<int>();
for (int i = 0; i < 40; i++)
{
    numbers.Add(i);
    Console.WriteLine($"numbers.count => {numbers.Count} , numbers.Capacity => {numbers.Capacity}"); // How memory is allocated for the list
}

numbers.Capacity = numbers.Count; // Clears space in the memory
numbers.TrimExcess(); //Same function but more efficient

Console.WriteLine($"numbers.count => {numbers.Count} , numbers.Capacity => {numbers.Capacity}");

var myArray = new int[50];
Array.Resize(ref myArray, 25);