
/*var myDelegate = new MyDelegate(CountWords);

Func<string, int> Delegate= CountWords;

Console.WriteLine(myDelegate.Invoke("Hello World"));

myDelegate= CountChars;

Console.WriteLine(myDelegate("Hello World"));

myDelegate = null;

Console.WriteLine(myDelegate?.Invoke("Hello World"));

if (myDelegate is not null)
{
    Console.WriteLine(myDelegate.Invoke("Hello World"));
}

var strings = new string[] { "Hello World", "Good morning", "Hey" };

ProcessArray(strings, CountChars);
static void ProcessArray(string[] strings, MyDelegate myDelegate)
{   foreach (var item in strings)
    {
        Console.WriteLine(myDelegate(item));
    }

}

static int CountChars(string text)
{
    return text.Length;
}

static int CountWords(string text)
{
    return text.Split(' ').Length;
}

MyOtherDelegate functionDelegate = FunctionA;
functionDelegate += FunctionB;
functionDelegate += FunctionC;
functionDelegate.Invoke("Hello");

static void FunctionA(string text)
{
    Console.WriteLine($"FunctionA{text}");
}

static void FunctionB(string text)
{
    Console.WriteLine($"FunctionB{text}");
}

static void FunctionC(string text)
{
    Console.WriteLine($"FunctionC{text}");
}


public delegate int MyDelegate(string s);// Delegate

//Multicast delegate
public delegate void MyOtherDelegate(string s);

public delegate int MyGenericDelegate<T, TResult>(T x);

//Kommer för det mesta inte behöva använda dessa. Rekomenderat att använda Func istället

//Använd generiska delegat (Func (returvärde), Action ( inget returvärde) 
//Func< in T1, in T2,... out Tresult>
//Action<in T1, In T2, ...>*/


////////////////////////////////////////////////////////////////////////////////////


//# Övningsuppgifter med delegat och lambda

//## 1. Deklarera en egen delegat-typ
//Skriv en metod som tar två strängar: firstName och lastName. Metoden ska returnera en ny sträng som är hela namnet.
//Deklarera en delegat-typ, och gör en variabel som är en referens till metoden. Anropa metoden via delegatet.
/*
myDelegate name = FullName;

string fullname = name("Julia ", "Robinson");
Console.WriteLine(fullname);

static string FullName(string firstName, string lastName)
{
    return firstName + lastName;
}
public delegate string myDelegate(string firstName, string lastName);
*/


//## 2. Använd generiskt delegat
//Ändra koden i uppgiften ovan så att den använder ett generiskt delegat istället för den du själv deklarerade.
/*

Func <string, string, string> name = FullName;
string fullname = name("Julia ", "Robinson");
Console.WriteLine(fullname);
static string FullName(string firstName, string lastName)
{
    return firstName + lastName;
}
*/

//## 3. Metod som tar delegat som inparameter
//Skriv en ny metod som också tar firstName och lastName. Denna metoden ska returnera en sträng som innehåller variabelnamnen och dess värden på två rader.

//Exempel:
//```
//firstName: Fredrik
//lastName: Johansson
//```
//Skriv sedan en metod som tar ett generiskt delegat (som matchar metoden ovan) som inparameter.
//Metoden ska, i tur och ordning, anropa delegatet med 3 olika för- och efternamn och skriva ut resultatet.
//Testa att anropa denna metod först med en referens till metoden i uppgift 1 och sedan med metoden ovan (uppgift 3).
/*
Func<string, string, string> name = FullName;
printNames(name);
static void printNames(Func<string, string, string> name)
{
    string fullname1 = name("Julia ", "Robinson");
    Console.WriteLine(fullname1);

    string fullname2 = name("Lucas", "Mills");
    Console.WriteLine(fullname2);

    string fullname3 = name("William", "Ross");
    Console.WriteLine(fullname3);
}


static string FullName(string firstName, string lastName)
{
    return ($"firstName: {firstName}\nlastName: {lastName}");
}
*/

//## 4. Skriv ut summan av två värden
//Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och skriver ut summan av dessa på konsolen. Testa genom att anropa med två värden.


// Func<int, int, int> total = (x, y) => x + y;
// Console.WriteLine(total(5, 7));





//## 5. Returnera summan av två värden
//Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och returnerar summan av dessa.
//Testa genom att anropa med två värden, och skriva ut resultatet.
/*int addNumbers()
{
    Func<int, int, int> total = (x, y) => x + y;
    return total(5, 7);
}
Console.WriteLine(addNumbers());           
*/

//## 6. Lambda som argument
//Anropa metoden (den som tar ett generiskt delegat) i uppgift 3.
//Som argument skriver du ett lambdauttryck som returnerar en string med antal tecken i namnen:
//Ex. "firstName has 7 letters, lastName has 9 letters."

/*   

   var names = printNames((firstName, lastName) => $"{firstName} has {firstName.Length} letters, {lastName} has {lastName.Length} letters.");

    Console.WriteLine(names);

    static string printNames(Func<string, string, string> name)
    {
        string fullname1 = name("Julia ", "Robinson");
        string fullname2 = name("Lucas", "Mills");
        string fullname3 = name("William", "Ross");
        return $"{fullname1}\n {fullname2},\n {fullname3} ";
    }

*/
//## 7. Modifiera utskrift med lambdauttryck 
//Skriv en metod som tar en string[] som inparameter och skriver ut alla strängar i arrayen på varsin rad.
//Uppdatera sedan metoden så att den tar en andra parameter: Func<string, string> modifier,
//och anropa modifier() på varje string i arrayen innan du skriver ut den. //Skapa en en string[] med namnen på fem städer som du kan skicka in i metoden.
//Gör 3 anrop till metoden (med olika lambda-uttryck):
//-Ett som skriver ut alla städer i UPPERCASE
//- Ett som skriver ut de 3 första tecknen i varje stad
//- Ett som skriver ut längden på varje stads namn.

/*string[] StringArray = new string[] { "Tokyo", "Stockholm", "New York", "Berlin", "Amsterdam" };


static void PrintCities (string[] strings, Func<string, string> modifier)
{
    foreach(var s in strings)
    {
        Console.WriteLine(modifier(s));
    }
}

PrintCities(StringArray, s => s.ToUpper());
PrintCities(StringArray, s => s.Substring(0, 3));
PrintCities(StringArray, s => s.Length.ToString());
*/

//## 8. Filtrera array (utskrift)
//Skapa en metod som tar en array med heltal, samt ett delegat som tar en int som inparameter och returnerar en bool.
//Metoden ska sedan anropa delegatet för varje tal i arrayen och endast skriva ut de tal som returnerar true.
//Skapa en int[] med 10 tal som du kan skicka in i metoden:
//Gör 3 anrop till metoden:
//-Ett som listar alla negativa tal
//- Ett som listar alla tal mellan 10 och 20
//- Ett som listar alla jämna tal

/*
int[] integerArray = new int[] { 11, 4, 19, 25, 2, 19, 22, -21, 18, 33, 89, 1 };

static void TheNumbers(int[] i, Func<int, bool> function)
{
    foreach (int n in i)
    {
        if (function(n))
        {
            Console.WriteLine(n);
        }

    }
}
TheNumbers(integerArray, n => n < 0);
Console.WriteLine();
TheNumbers(integerArray, n => n >= 10 && n <= 20);
Console.WriteLine();
TheNumbers(integerArray, n => n % 2 == 0);

*/


//## 9. Filtrera array (till ny array)
//Gör om metoden i uppgift 8 så att den istället för att skriva ut talen returnerar en ny array med de tal som matchar villkoren i lambdautrycket man skickar in.
/*int[] integerArray = new int[] { 11, 4, 19, 25, 2, 19, 22, -21, 18, 33, 89, 1 };

static int[] TheNumbersMason(int[] i, Func<int, bool> function)
{
    List<int> result = new List<int>();
    foreach (int n in i)
    {
        if (function(n))
        {
            result.Add(n);
        }
       
    }
    return result.ToArray();
}
int[] negative = TheNumbersMason(integerArray, n => n < 0);
Console.WriteLine($"Negatives: {string.Join(" ",negative)}\n");
Console.WriteLine();

int[] TenToTwenty = TheNumbersMason(integerArray, n => n >= 10 && n <= 20);
Console.WriteLine($"Numbers between 10 and 20: {string.Join(" ",TenToTwenty)}\n");
Console.WriteLine();

int[] EvenNumbers =TheNumbersMason(integerArray, n => n % 2 == 0);
Console.WriteLine($"Even numbers :{string.Join(" ", EvenNumbers)} \n");
Console.WriteLine();
*/