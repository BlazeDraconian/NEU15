Size mySize = Size.Medium;
Color myColor = Color.Blue;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"mySize = {mySize}");
Console.WriteLine($"myColor = {myColor}");

Point p1 = new Point(3.0, 5.0);
Point p2 = p1;
p1.X = 8;
Console.WriteLine(p1.Equals(p2));
//Motsvarigheten till Console.Writeline(p1 == p2);
Console.WriteLine($"p1 = ({p1.X}; {p1.Y})");
Console.WriteLine($"p2 = ({p2.X}; {p2.Y})");
struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        this.X = x; this.Y = y;
    }
}

enum Size: byte { Small, Medium, Large}; //Lagras som en byte, då vi har angett det.
enum Color // Default är att det lagras som en Int32.
{
    White,
    Black,
    Red,
    Green,
    Blue,
    Yellow
}