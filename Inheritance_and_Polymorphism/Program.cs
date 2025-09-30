using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.ForegroundColor= ConsoleColor.Blue;

//# Övningsuppgifter med arv och polymorfism

//## 1. Skapa en klass för fordon
//Skapa en enum Brand med 5 bilmärken, och en enum Color med 5 färger. Skriv sedan en klass Vehicle som har publika properties Brand och Color.
//Klassen ska ha en konstruktor som man kan använda för att sätta Brand och Color, och en konstruktor som endast tar Brand och sätter en default färg.
/*
Vehicle Car1 = new Vehicle(Brand.Volvo, Color.Green);
Vehicle Car2 = new Vehicle(Brand.Volvo);
Console.WriteLine($"{Car1.Brand} i färgen {Car1.Color}");
Console.WriteLine($"{Car2.Brand} i färgen {Car2.Color}");

enum Brand
{
    Ford,
    Toyota,
    Volvo,
    BMW,
    Fiat,
}

enum Color
{
    Red, Green, Blue, White, Black,
}


class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;

    }
}
*/

//## 2. Lägg till override för ToString()
//ToString() är en metod som alla klasser ärver från System.Object. Denna metod anropas implicit när man skickar in ett objekt till Console.WriteLine, eller använder ett objekt i en konkatenering
//(t.ex en interpolation string). Implementationen i System.Object är sådan att den bara skriver ut objektets datatyp, men din klass kan göra en override på ToString()
//och returnera en sträng i vilket format du vill. Gör en override på ToString() i Vehicle-klassen, så att "A white Toyota" skrivs ut om man kör följande kod:

//```cs
//Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));
//```

/*

Console.WriteLine(new Vehicle(Brand.Toyota, Color.White));
enum Brand
{
    Ford,
    Toyota,
    Volvo,
    BMW,
    Fiat,
}

enum Color
{
    Red, Green, Blue, White, Black,
}


class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;

    }

    public override string ToString()
    {
        return $" A {Color} {Brand}";
    }
}
*/

//## 3. Skapa en subklass för bilar
//Skapa en klass Car som ärver av Vehicle. Lägg till en publik property Model, och skapa en konstruktor som initierar Brand, Model och Color.
//"A white Yaris from Toyota" ska skrivas ut om man kör följande kod:
//```cs
//Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
//```

/*
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
enum Brand
{
    Ford,
    Toyota,
    Volvo,
    BMW,
    Fiat,
}

enum Color
{
    Red, Green, Blue, White, Black,
}


class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;

    }

    public override string ToString()
    {
        return $" A {Color} {Brand}";
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(Brand Brand, string model, Color Color)
        : base(Brand, Color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {Color} {Model} from {Brand}";
    }
}
*/


//## 4. Skapa en struct för att spara längd, bredd och höjd.
//Skapa en struct Size med properties Length, Width och Height; samt en konstruktor som tar 3 argument för att initiera dessa.

/*
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
Size s = new Size(5.0, 2.5, 2.3);
Console.WriteLine(s);
enum Brand
{
    Ford,
    Toyota,
    Volvo,
    BMW,
    Fiat,
}

enum Color
{
    Red, Green, Blue, White, Black,
}


class Vehicle
{
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;

    }

    public override string ToString()
    {
        return $" A {Color} {Brand}";
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(Brand Brand, string model, Color Color)
        : base(Brand, Color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {Color} {Model} from {Brand}";
    }
}
struct Size
{
    public double Lenght;
    public double Width;
    public double Height;

    public Size(double lenght, double height, double width)
    {
        Lenght = lenght; Height = height; Width = width;

    }
    public override string ToString()
    {
        return $"Length: {Lenght}, Width: {Width}, Height: {Height}";
    }
}
*/

//## 5. Initiera i Vehicle, skriv ut i Car.
//Uppdatera Vehicle-klassen så den sätter slumpmässiga (men rimliga) värden för längd, bredd och höjd. Uppdatera Car-klassen så att även längden skrivs ut när samma kod som i uppgift 3 körs.

//Ex: "A white 4.1 meter long Yaris from Toyota".

/*
Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));
enum Brand
{
    Ford,
    Toyota,
    Volvo,
    BMW,
    Fiat,
}

enum Color
{
    Red, Green, Blue, White, Black,
}


class Vehicle
{
    private static Random random = new Random();
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Size size { get; set; }

    public Vehicle(Brand brand, Color color)
    {
        Brand = brand;
        Color = color;

        size = new Size(
         random.NextDouble() * (5.0 - 3.0) + 3.0,   
         random.NextDouble() * (2.0 - 1.5) + 1.5,   
         random.NextDouble() * (2.0 - 1.0) + 1.0    
     );
    }

    public Vehicle(Brand brand)
    {
        Brand = brand;
        Color = Color.Black;

    }

    public override string ToString()
    {
        return $" A {Color} {Brand}";
    }
}

class Car : Vehicle
{
    public string Model { get; set; }

    public Car(Brand Brand, string model, Color Color)
        : base(Brand, Color)
    {
        Model = model;
    }
    public override string ToString()
    {
        return $"A {Color} {size.Lenght:F1} meter long {Model} from {Brand}";
    }
}
struct Size
{
    public double Lenght;
    public double Width;
    public double Height;

    public Size(double lenght, double height, double width)
    {
        Lenght = lenght; Height = height; Width = width;

    }
    public override string ToString()
    {
        return $"Length: {Lenght}, Width: {Width}, Height: {Height}";
    }
}

*/


//## 6. Circle som ärver från Shape

//Utgå från följande kod:

/*```cs
public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}
```

//Skapa en klass Circle som ärver från klassen ovan.
//Implementera Circle på så vis att koden nedan ...

```cs
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");
```

... ger följande utskrift:

```
A circle with radius 5
Area: 78,54
Circumference: 31,42
```
*/
/*
var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius}";
    }
}
*/

//## 7. Square ärver också från Shape

//Skapa även en klass Square som ärver från Shape. //Implementera Square på så vis att koden nedan ...
/*
```cs
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");
```

... //ger följande utskrift:

```
A square with side 5
Area: 25,00
Circumference: 20,00
```
*/
/*
var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area => Side * Side ;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side}";
    }
}
*/


//## 8. Lägg till Print() i Shape

//Uppdatera(endast) den abstrakta basklassen med en Print() method. När detta är gjort ska koden nedan ...

/*```cs
var square = new Square(3.2);
square.Print();

var circle = new Circle(4.5);
circle.Print();
```
... ge följande utskrift:

```
A square with side 3,2 has an area of 10,24 and a circumference of 12,80.
A circle with radius 4,5 has an area of 63,62 and a circumference of 28,27.
```*/
/*
var square = new Square(3.2);
square.Print();

var circle = new Circle(4.5);
circle.Print();

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    public void Print()
    {
        Console.WriteLine($"{ToString()} has an area of {Area:f2} and circumference of {Circumference:f2} ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area => Side * Side ;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side}";
    }
}*/

//## 9. En array av cirklar och kvadrater
//```cs
//Shape[] shapes = new Shape[10];
//```*/

//Skriv en loop som slumpmässigt initerar alla element i arrayen med antingen cirklar med 0 < radie < 10, eller kvadrater med 0 < sida < 10.
//Sätt en breakpoint efter loopen och inspektera arrayen i Visual Studios debugger.
/*
Random random = new Random();
Shape[] shapes = new Shape[10];


for (int i = 0; i < shapes.Length; i++)
{
    if (random.Next(2) == 0)
    {
        double radius = random.NextDouble() * 10 , 2;
        shapes[i] = new Circle(radius);
    }

    else
    {
        double side = random.NextDouble() * 10, 2;
        shapes[i] = new Square(side);
    }
}

foreach (Shape shape in shapes)
{
    shape.Print();
}




public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    public void Print()
    {
        Console.WriteLine($"{ToString()} has an area of {Area:f2} and circumference of {Circumference:f2} ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area => Side * Side;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side}";
    }
}

*/


//## 10. Statiska printmetoder
//Lägg till en statisk metod PrintAll() i Shape som anropar Print() på alla shapes i en array. Lägg även till en statisk metod PrintCircles() som endast anropar Print() på alla cirklar i en array.
//Prova sedan att köra följande kod:

/*```cs
Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);
```*/
//(där shapes är arrayen från uppgift 9) Ovanstående ska skriva ut först alla shapes i arrayen, följt av blankrad, följt av alla circles i arrayen.
/*
Random random = new Random();
Shape[] shapes = new Shape[10];

for (int i = 0; i < shapes.Length; i++)
{
if (random.Next(2) == 0)
{
double radius = random.NextDouble() * 10;
shapes[i] = new Circle(radius);
}

else
{
double side = random.NextDouble() * 10;
shapes[i] = new Square(side);
}
}

Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);



public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    public static void PrintAll(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            shape.Print();
        }

    }

    public static void PrintCircles(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            if (shape is Circle)
            {
                shape.Print();
            }
        }
    }

    public void Print()
    {
        Console.WriteLine($"{ToString()} has an area of {Area:f2} and circumference of {Circumference:f2} ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius:F2}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area => Side * Side;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side:F2}";
    }
}
*/

//## 11. Lägg till färger i PrintAll()
//Uppdatera PrintAll() i uppgift 10, så att alla rader med cirklar skrivs med röd färg och alla rader med kvadrater skrivs med grön färg.
/*
Random random = new Random();
Shape[] shapes = new Shape[10];

for (int i = 0; i < shapes.Length; i++)
{
if (random.Next(2) == 0)
{
double radius = random.NextDouble() * 10;
shapes[i] = new Circle(radius);
}

else
{
double side = random.NextDouble() * 10;
shapes[i] = new Square(side);
}
}

Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);



public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
    public static void PrintAll(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {   
            if (shape is Circle)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                shape.Print();
                Console.ResetColor();
            }
            else if (shape is Square)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                shape.Print();
                Console.ResetColor();
            }
        }

    }

    public static void PrintCircles(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            if (shape is Circle)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                shape.Print();
                Console.ResetColor();
            }
        }
    }

    public void Print()
    {
        Console.WriteLine($"{ToString()} has an area of {Area:f2} and circumference of {Circumference:f2} ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius:F2}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }
    public override double Area => Side * Side;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side:F2}";
    }
}
*/

//## 12. Random färger
//Lägg till följande i Shape
/*
```cs
protected ConsoleColor color;
```
*/
//Uppdatera sedan subklasserna med en variant (overload) av konstruktorn som även tar en färg. Använd dig av constructor chaining.
//Uppdatera PrintAll() så att raden skrivs ut i den färg som angavs när vardera shape skapades. Uppdatera loopen som initierar arrayen så att varje shape som skapas får en random färg.

/*
Random random = new Random();
Shape[] shapes = new Shape[10];
ConsoleColor[] AllTheColors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
for (int i = 0; i < shapes.Length; i++)
{
    ConsoleColor randomColor = AllTheColors[random.Next(AllTheColors.Length)];
if (random.Next(2) == 0)
{
double radius = random.NextDouble() * 10;
shapes[i] = new Circle(radius, randomColor);
}

else
{
double side = random.NextDouble() * 10;
 shapes[i] = new Square(side, randomColor);
}
}

Shape.PrintAll(shapes);
Console.WriteLine();
Shape.PrintCircles(shapes);



public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    protected ConsoleColor color;
    public static void PrintAll(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            Console.ForegroundColor = shape.color;
            shape.Print();
            Console.ResetColor();
            
        }

    }

    public static void PrintCircles(Shape[] shapes)
    {
        foreach (Shape shape in shapes)
        {
            if (shape is Circle)
            {
                Console.ForegroundColor = shape.color;
                shape.Print();
                Console.ResetColor();
            }
        }
    }

    public void Print()
    {
        Console.WriteLine($"{ToString()} has an area of {Area:f2} and circumference of {Circumference:f2} ");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public Circle(double radius, ConsoleColor color) : this(radius)
    {
        this.color = color;
    }
    public override double Area => Math.PI * Radius * Radius;

    public override double Circumference => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"A Circle with radius: {Radius:F2}";
    }
}

class Square : Shape
{
    public double Side { get; set; }
    public Square(double side)
    {
        Side = side;
    }

    public Square(double side, ConsoleColor color) : this(side)
    {
        this.color = color;
    }
    public override double Area => Side * Side;

    public override double Circumference => Side * 4;

    public override string ToString()
    {
        return $"A square with side: {Side:F2}";
    }
}
*/