

//using (var reader = new StreamReader("MyFile.txt"))
//{
//...
//}

/*using (var cat = new Cat())
{
    Console.WriteLine("Cat");
}
Console.WriteLine("The end");
*/

var myCat = new Cat("Snow");
myCat.Collect();
class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name= name;
    }

}

class Cat : Animal, IDisposable, ICollectible
{
    public Cat(string name) : base(name) 
    {
    }

    public void Collect()
    {
        Console.WriteLine($"{Name} was collected");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
}
interface ICollectible
{
    public void Collect();
}