using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
person myPerson = new person("Alex");
Console.WriteLine(myPerson.GetName());
myPerson.SetName("Anders");
Console.WriteLine(myPerson.GetName());

//myPerson.Name = "Reset"; //Fungerar inte om myPerson.name är private
Console.WriteLine(myPerson.Name);
myPerson.Name = "Test";
Console.WriteLine(myPerson.Name);
class person
{
    private string name = string.Empty;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            this.name = value;
        }
    }

    public person(string name)
    {
        this.name = name;
    }
    public void SetName(string name)
    {   if (name.Length > 10)
        {
            throw new ArgumentException();
        }
        this.name = name; 
    }
    public string GetName()
    {
        return this.name.ToUpper();
    }
}
*/
//public int MyProperty { get; set; } //Auto property ( tryck in "Prop" som shortcut )
// private int _age = 0; // Backing field till Age, privat och börjar med _
/*
private int myVar;

public int MyProperty
{
    get { return myVar; }
    set { myVar = value; }
}  //"Propfull" är en shortcut för att snabbt skapa en property 

*/
//# Övningsuppgifter med properties

//## 1. Person med property FirstName
//Skapa en klass "Person" som har en private field _firstName, och en public property FirstName.
//När man sätter värdet på FirstName ska detta sparas i _firstName, och när man läser värdet på FirstName ska den returnera det som finns lagrat i _firstName.

/*
Person Person1 = new Person();
Console.WriteLine(Person1.FirstName);
class Person
{
    private string _firstName = "Name" ;
    

    public  string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }


}
*/

//## 2. Autoproperty LastName
//Lägg till en publik auto-property LastName som går att både läsa och skriva.
/*
Person Person1 = new Person();
Console.WriteLine(Person1.FirstName);
class Person
{
    private string _firstName = "Name";
    public string LastName { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }


}
*/


//## 3. Read-only property FullName
//Lägg sedan till en publik property FullName som är read only (bara get;) När man läser av propertyn så ska den returnera hela namnet.
//Testa koden genom att skapa ett objekt, tilldela värden på både FirstName och LastName, och sedan skriva ut FullName.

/*
Person Person1 = new Person();
Person1.LastName = "A";
Console.WriteLine(Person1.FirstName);
Console.WriteLine(Person1.FullName);
class Person
{
    private string _firstName = "Name";
    public string LastName { get; set; }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string FullName 
    {
        get { return FirstName + " " + LastName; }
   
    }

}
*/

//## 4. Stegräknare
//Skapa en klass som kan användas som stegräknare. Den ska ha en property "Steps" som bara går att läsa; en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
//och en metod Reset() som nollställer räknaren.
//Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg. Skriv ut värdet på Steps.

/*
StepCounter counter = new StepCounter();
for (int i = 0; i < 1000; i++)
{
    counter.Step();
    Console.WriteLine($" {counter.Steps}");
}
class StepCounter
{
    private int steps;

    public int Steps
    {
        get { return steps; }
    }


    public void Step()
    {
        steps++;
    }

    public void Reset()
    {
        steps = 0;
    }

    
}

*/


//## 5. Bil
//Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg. Skapa publika properties för att hämta eller ändra värdet på varje field.
//Skriv en konstruktor till bilklassen som inte tar några parametrar. Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa. 
//Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?
//Skriv en metod till bilklassen med namnet HalfPrice(). När den anropas ska priset på bilen sänkas till hälften.

/*
car Car = new car();
Car.Cost = 1000;
Console.WriteLine($"Halva priset är  {Car.HalfPrice()} ");
class car
{
    private string model;
    private int cost;
    private string color;



    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }


    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public void car1()
    {

    }

    public void Car1(int cost, string model, string color)
    {

        this.cost = cost;
        this.model = model;
        this.cost = cost;

    }

    public int HalfPrice()
    {
        return cost/2;
    }
}
*/

//## 6. Vattenglas
//Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, och en metod för att tömma glaset. 
//Dessutom ska den ha en private field som håller reda på om glaset är tomt eller fullt. Beroende på tillståndet (tomt/fullt) så ska metoden som fyller glaset skriva ut antingen “Fyller glaset” 
//eller “Glaset är redan fullt”. Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

/*
GlassOfWater emptyOrFull = new GlassOfWater();
emptyOrFull.FillGlass();
emptyOrFull.FillGlass();

class GlassOfWater
{
    private bool isfull = false;

    public void FillGlass()
    {
        if (isfull) 
        
        {
            Console.WriteLine("Glaset är redan fullt");
            isfull = false;
            Console.WriteLine("Tömmer glaset");

        }
        else  
        {
            Console.WriteLine("Glaset är tomt");
            isfull = true;
            Console.WriteLine("Fyller glaset");
        }
        

    }
}
*/


//## 7. Blå & Röd 
//Skapa en en klass som har en property “Red” och en property “Blue”. Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0  men de ska vara “sammankopplade” 
//på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex. sätter “Blue” till 8.5 och sedan läser av “Red” så ska den returnera 91.5
/*

RedVSBlue RvB = new RedVSBlue();

Console.WriteLine($"Red has the value");
Console.WriteLine( RvB.Red);
Console.WriteLine($"Blue has the value");
Console.WriteLine(RvB.Blue);
class RedVSBlue
{
    private double red = 46;

    public double Red
    {
        get { return red; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Red måste vara mellan 0 och 100");
                red = value;
            }



        }
    }

    public double Blue
    {
        get { return 100 - red; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Blue måste vara mellan 0 och 100");
                red = 100 - value;
            }
        }
    }


}

*/

/*## 8. Temperatur
Implementera klassen Temperature så att nedanstående kod fungerar, och korrekt omvandlar mellan enheterna.
```cs
Temperature t = new() { Celcius = 0 };

Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
Console.WriteLine($"Celcius:  {t.Celcius,10:f2}");
Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");
```
Det ska såklart fungera oavsett vilken enhet och värde man väljer på första raden, när instansen skapas.

**Tips:** [Omräkningsformler](https://www.cuemath.com/temperature-conversion-formulas/)

*/
/*
Temperature t = new() { Celsius = 38 };

Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
Console.WriteLine($"Celcius:  {t.Celsius,10:f2}");
Console.WriteLine($"Farenheit:{t.Fahrenheit,10:f2}");
class Temperature
{
    private double kelvin;
    public double Kelvin
    {
        get { return kelvin; }
        set { kelvin = value; }
    }
    private double celsius;

    public double Celsius
    {
        get { return kelvin - 273.15; }
        set { kelvin = value + 273.15; }
    }

    private double fahrenheit;

    public double Fahrenheit
    {
        get { return (kelvin - 273.15) * 9 / 5 + 32; ; }
        set { Kelvin = (value - 32) * 5 / 9 + 273.15; }
    }

    

   

}
*/

//## 9. Bil 2
//Skriv en ny klass som representerar en bil.Varje bil ska kunna ha en färg som representeras av en ConsoleColor, 
//samt en längd.När man instansierar en bil så ska den få en random färg, och en random längd(mellan 3 och 5 meter).Instansiera 1000 bilar och spara i en array.
//Skapa en funktion som tar en array av bilar och returnerar den sammanlagda längden av alla gröna bilar.
/*
Car[] cars = new Car[1000];
for (int i = 0; i < cars.Length; i++)
{
    cars[i] = new Car();
}

double GreenLength = SumGreenCars(cars);
Console.WriteLine($"Längden av alla gröna bilar är {GreenLength} meter");

double SumGreenCars(Car[] cars)
{
    double sum = 0;
    foreach (Car car in cars)
    {
        if (car.color == ConsoleColor.Green)
        {
            sum += car.length;
        }
    }
    return sum;
}

class Car
{
    private static Random random = new Random();

    public ConsoleColor color { get; private set; }
    public double length { get; private set; }

    public Car()
    {
        Array colors = Enum.GetValues(typeof(ConsoleColor));
        color = (ConsoleColor)colors.GetValue(random.Next(colors.Length));
        length = random.NextDouble() * (5.0 - 3.0) + 3.0;
    }
  
}

*/




//## 10. Lägg till statisk metod
//Lägg till en statisk metod på klassen i uppgift 9.Metoden ska ta en bil som inparameter och returnera en array med 10 bilar i samma färg som bilen man skickat in, men med olika längd.
Car car1 = new Car();
Console.WriteLine($"Original bil: {car1.color}, {car1.length:f2} m");
Car.CreateCarsOfSameColor(car1);
Car[] cars = new Car[1000];
for (int i = 0; i < cars.Length; i++)
{
cars[i] = new Car();
}

double GreenLength = SumGreenCars(cars);
Console.WriteLine($"Längden av alla gröna bilar är {GreenLength} meter");

double SumGreenCars(Car[] cars)
{
double sum = 0;
foreach (Car car in cars)
{
if (car.color == ConsoleColor.Green)
{
sum += car.length;
}
}
return sum;
}

class Car
{
    private static Random random = new Random();

    public ConsoleColor color { get; private set; }
    public double length { get; private set; }

    public Car()
    {
        Array colors = Enum.GetValues(typeof(ConsoleColor));
        color = (ConsoleColor)colors.GetValue(random.Next(colors.Length));
        length = random.NextDouble() * (5.0 - 3.0) + 3.0;
    }

    public Car(ConsoleColor color, double length)
    {
        this.color = color;
        this.length = length;
    }
    public static Car[] CreateCarsOfSameColor(Car prototype)
    {
        
        Car[] same = new Car[10];
        for (int i = 0; i < same.Length; i++)
        {
            double randomLength = random.NextDouble() * (5.0 - 3.0) + 3.0;
            same[i] = new Car(prototype.color, randomLength);
            Console.WriteLine($"Bil {i + 1}: {same[i].color}, {same[i].length:f2} m");
        }
        return same;
    }
}
