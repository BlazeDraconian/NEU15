Console.ForegroundColor = ConsoleColor.Blue;

int a = 5;
int b = a; //Kopierar värdet 5 till b
a = 3;
Console.WriteLine($"a = {a}, b = {b}");

Person A = new Person() { Name = "Lambert"};
Person B = A;  //Kopierar referensen Lambert till B


//Om man ändrar namnet på objektet som A refererar till, så är det sammaonjekt som B refererar till.
//A.Name = "Darius";

A = new Person() { Name = "Darius" };// Om man däremot ändrar referensen i sig så påverkas inte referensen B

Console.WriteLine($"Person A.name = {A.Name}, Person B = {B.Name}");
Console.WriteLine();
PassValueTypeByValue(a);
Console.WriteLine($"PassValueTypeByValue(a)  => {a}\n");
PassValueTypeByReference(ref a);
Console.WriteLine($"PassValueTypeByReference(a)  => {a}\n");
static void PassValueTypeByValue(int x)
{
    x += 2;
    Console.WriteLine($" x = {x}");
}

static void PassValueTypeByReference(ref int x)
{
    x += 2;
    Console.WriteLine($" x = {x}");
}
PassReferenceTypeByValue(A);
Console.WriteLine($"PassReferenceTypeByValue= {A.Name}");
PassReferenceTypeByReference(ref A);
Console.WriteLine($"PassReferenceTypeByReference = {A}\n");
static void PassReferenceTypeByValue(Person P)
{
    //P.Name = "Cyrus";
    P= new Person() {Name = "Cyrus" };
    Console.WriteLine($"p.name = {P.Name}");
}
static void PassReferenceTypeByReference(ref Person P)
{
    P.Name = "Cyrus";
    P = new Person() { Name = "Cyrus" };
    Console.WriteLine($"p.name = {P.Name}");
}
class Person
{
    public string Name;
}