
 

//-----------------------------------------------------------------------------------------------------------------------------

/*
int x = 5; int y = 3;

Console.WriteLine($"x = {x} , y = {y}");

Swap(ref  x, ref y);


Console.WriteLine($"x = {x} , y = {y}");


static void Swap<T>(ref T a , ref T b)
{
    T hold = a;
    a = b; 
    b = hold;
}

Console.WriteLine(AreAllElementsEqual(new int[] {2,2,2,2,2,2}));
Console.WriteLine(AreAllElementsEqual(new char[] { '2', '2', '2', '2', '2', '3' }));

static bool AreAllElementsEqual<T>(T[] array)
{
    if (array.Length == 0) return true;
    for (int i = 0; i < array.Length; i++)
    {
        if (!Object.Equals(array[i], array[0])) return false;
    }
    return true;
}

string textA = "Hello";
string textB = "World";

Console.WriteLine($"\nText a = {textA} , Text b = {textB}");

Swap(ref textA, ref textB);

Console.WriteLine($"\nText a = {textA} , Text b = {textB}");

*/

//-----------------------------------------------------------------------------------------------------------------------------
/*
var birdcage = new Cage<Bird>();
birdcage.Inhabitant = new Bird();

var catcage = new Cage<Cat>();
catcage.Inhabitant = new Cat();


var cage = new DoubleCage<Bird, Cat>();
class Bird
{

}

class Cat
{

}

class DoubleCage<T1 ,T2>()
{
    public T1 FirstInhabitant { get; set; }
    public T2 SecondInhabitant { get; set; }
}
*/

