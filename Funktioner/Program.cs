using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Json;

/*static void FunctionA() 
{
    Console.WriteLine("This is FunctionA");
    FunctionB();
    Console.WriteLine("End of functionA");
}   

static void FunctionB()
{
    Console.WriteLine("Start of functionB");
    FunctionC();
    Console.WriteLine("End of functionB");
}

static void FunctionC()
{
    Console.WriteLine("This is functionC");
}
Console.WriteLine("First statement");
Console.WriteLine("Second statement");
FunctionA();

//En funtion kan ta 0, 1, eller flera Intparametrar
//Parametrar skrivs kommaseparerade i parentesen efter funktionsnamnet
//Varje parameter har en datatyp( Datatypen anges alltså per parameter
//En funktionssignatur består av namnet på funktionen följt av parametrar i parentesen,
static void MyFunction(string text, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(text);
    }
}
MyFunction("Min text", 3);
MyFunction("Lorem Ipsum" ,6);

Console.Write("Skriv text: ");
//String Uinput =  Console.ReadLine();
//MyFunction(Uinput, 2);

// Uppgift 1: Skriv en funtion som tar två heltal in och skriver ut summan av dessa på skärmen

static void UppgiftEtt(int heltal1, int heltal2)
{
    
    Console.Write(heltal1 + heltal2);
}
Console.WriteLine();
UppgiftEtt(6, 5);

// Uppgift 2: Skriv en funktion som tar två heltal t.ex 2 och 4 och skriver ut en string " 2 * 4 = 8"

static void Uppgifttvå(int heltal3, int heltal4)
{
   
    int multiply = heltal3 * heltal4;
    Console.WriteLine($"{heltal3} * {heltal4} = {multiply}");
}
Uppgifttvå(2, 4);

//En funktion kan returnera 0 eller 1 objekt. 
// Man anger datatypen på objektet som returneras före funktionsnamnet
//Alternativt använd "void" om funktionen inte returnerar ett värde
// Koden ( i funktionen) måste ALLTID returnera en matchchande datatyp
static int AddNumbers(int a, int b)
{
    return a + b;
}
int x = AddNumbers(3, 5);
Console.WriteLine(x);
//Keyword 'params' kan användas för att ta in ett okänt antal parametrar av samma datatyp.
//Man kan bara ha en params, och den måste vara sista parametern
//Man kan använda String.join för att skriva ut alla element i en array
//exempel:Console.WriteLine(string.Join(', ', myIntArray));
int count = 3;
 void ExampleWithoutStatic()
{
    Console.WriteLine(count);
}


static void ExampleWithStatic(int count)
{
    Console.WriteLine(count); //Funktioner märkta med 'static' har inte åtkonst till objekt utanför funktionen. 
}
ExampleWithStatic(5);
ExampleWithoutStatic();*/
//Tillsvidare,använd static på alla era funktioner för att få in tänket att fungerar fristående från annan kod. 

//ÖVNING 1 Skriv en funktion som tar två parametrar: firstName och lastName. Funktionen ska skriva ut hela namnet på skärmen. Testa genom att anropa funktionen med ditt namn.

static void MyName(string first, string last)
{
    Console.WriteLine($"Mitt namn är {first},{last}");
}
MyName("Daniel" , "Gustafsson");

//ÖVNING2 Skriv om funktionen ovan så att den istället för att skriva ut namnet returnerar en string med hela namnet. Anropa funktionen och skriv ut returvärdet.

static void MyName2(string first, string last)
{
    String HeltNamn = first + last;
    Console.WriteLine("Mitt namn är " + HeltNamn);
}
MyName2("Daniel", "Gustafsson");

//ÖVNING3 Skriv en funktion som tar in en sträng och ett heltal. Om längden på strängen är större än heltalet returnera true, annars false.

static bool StringLenght(string str, int length)
{
    if (str.Length> length)
    {
        Console.WriteLine("True");
        return true;
        
    }
    else
        Console.WriteLine("False");
    return false;
    
}
StringLenght("Adam", 5 );

//ÖVNING4 Skriv en funktion som översätter ett värde från Celsius till Fahrenheit. Både in-parameter och returvärde ska vara av datatyp double

static double CelToFahr(double temp)
{
    double fahr = (temp * 9 / 5 + 32);
    Console.WriteLine();
    return fahr;
}
double result = CelToFahr(40);
Console.WriteLine($" 40 celsius = {result} fahrenheit");


//ÖVNING 5 Skriv en funktion som tar in en sträng och returnerar en sträng med ett bindestreck mellan varje tecken. T.ex om man skickar in “Fredrik” , så returnerar den “F-r-e-d-r-i-k”
static void Fredrik(string namn)
{
    string FullName = string.Join("-",namn.ToCharArray());
    Console.WriteLine(FullName);
}
Fredrik("Fredrik");

//ÖVNING6 Skriv en egen funktion som fungerar på samma sätt som String.Join();
//Exempel: MyJoin("->", "Sverige", "Norge", "Finland");

static void Länder(String land1 , string land2,string land3 )
{
    string list = string.Join("->", land1 ,land2, land3);
    Console.WriteLine(list);
}
Länder("Sverge", "Norge", "Finland");

//ÖVNING7 Skriv en funktion som tar en int[] in, och returnerar medelvärdet som en double.

static double Medelvärde(int[] mid)
{
    double sum = 0;
    for (int i = 0; i < mid.Length; i++)
    {
        sum += mid[i];
    }
      double värde = sum / mid.Length;
    return värde;
}
double resultat = Medelvärde(new int[] { 5, 6, 9, 15 });
Console.WriteLine($"Medelvärdet av talen är {resultat}");

//ÖVNING8 Skriv en funktion som tar ett heltal in, och returnerar en string[] där varje element innehåller ordet för varje siffra i talet.

static string[] siftillord(int heltal)
{
    string[] siffror = { "Noll", "Ett", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio" };
    string taltillstr = heltal.ToString();
    string[] strings = new string[taltillstr.Length];
    for (int i = 0; i < taltillstr.Length; i++)
    {
        int input = int.Parse(taltillstr[i].ToString());
        strings[i] = siffror[input];
    }
    return strings;
}
string[] ord = siftillord(5692);
Console.WriteLine(string.Join(" ",ord));


//ÖVNING9 Skriv en funktion som tar en ushort som parameter, och returnerar en sträng med numret utskrivet i ord.

//Exempel: IntegerToText(6543); Returvärde: "six thousand five hundred forty three"

static string NumToText(ushort number)
{
    if (number == 0)
    {
        return "noll";
    }
    string[] singles = { "", "ett", "två", "tre" , "fyra" , "fem" , "sex" , "sju" , "åtta", "nio" , "tio", "elva" , "tolv" ,"tretton" ,"fjorton" ,"femton", "sexton" , "sjuton" , "arton" , "nitton" };
    string[] tens = {" ","tjugo", "trettio" , "fyrtio" , "femtio" , "sextio" , "sjutio" ,"åttio" , "nittio"};
    string resultat = (" ");
    if (number >= 1000)
    {
        resultat += singles[number / 1000] + "tusen";
        number %= 1000;
    }
    if (number >= 100)
    {
        resultat += singles[number / 100] + "hundra";
        number %= 100;
    }

    if (number >= 20)
    {
        resultat += tens[number / 10] + "";
        number %= 10;
    }

    if (number > 0)
    {
        resultat += singles[number] + "";
    }

    return resultat;
}
ushort siffra = 6543;
Console.WriteLine(NumToText(siffra));

//ÖVNING10 Skapa funktionen int[] IndexesOf(string text, char c) som söker igenom strängen text och returnerar en int[] med index till alla förekomster av c i text.
static int[] IndexesOf(string text, char c)
{
    List<int> lista = new List<int>();
    for (int i = 0; i< text.Length; i++)
    {
        
        if (text[i] == c)
        {
            lista.Add(i);
        }
        
    }
    return lista.ToArray();
}
int[] AllC = IndexesOf("cykel", 'c');
Console.WriteLine(string.Join(", ", AllC));

//ÖVNING11 Skriv en funktion ThrowDice() som returnerar ett slumpmässigt heltal 1-6. Skriv en annan funktion ThrowMultipleDice(int n) som returnerar resultatet av att man slagit n tärningar.

static int ThrowDice()
{
    Random rng = new Random();
    return rng.Next(1, 7); // 1–6
}

static int[] ThrowMultipleDice(int n)
{
    int[] mulp = new int[n];
    for (int i = 0; i < n; i++)
    {
        mulp[i] = ThrowDice();
    }
    return mulp;
}

// Exempelanrop
int oneDie = ThrowDice();
Console.WriteLine($"Du slog: {oneDie}");

int n = 5;
int[] manyDice = ThrowMultipleDice(n);
Console.WriteLine("Du slog tärningarna: " + string.Join(", ", manyDice));

