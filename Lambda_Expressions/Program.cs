
using System.Diagnostics.CodeAnalysis;

Func<int, int> square = x => x * x;
Console.WriteLine(square.Invoke(5)); //Samma sak som funktionen nedan.
//static int Square(int x)
//{
//    return x * x;
//}
//

Action<int> PrintInt = i => Console.WriteLine(i);
PrintInt(square(8));
//


PrintResults (x => x * 2);
Console.WriteLine();

PrintResults(n =>
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += i;
    }
    return sum;
});
    static void PrintResults(Func<int, int> func)
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine($"{i}: {func(i)}");
    }
}
//

Func<Person,int, bool> islegal = (Person, legalage) => Person.age>= legalage;
Console.WriteLine(islegal(new Person() { age = 20 }, 18));



Func<double, double, double> VolumeCylinder = (radius, height) =>  radius * radius * Math.PI * height;
Console.WriteLine(VolumeCylinder( 5 , 2));
class Person
{
    public int age { get; set; }
}
//

