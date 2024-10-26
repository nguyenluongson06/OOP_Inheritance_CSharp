namespace OOP_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        var rect = new Rectangle(3, 4);
        var sq = new Square(4);
        Console.WriteLine($"Rectangle area: {rect.Area()}; Rectangle perimeter: {rect.Perimeter()}");
        Console.WriteLine($"Square area: {sq.Area()}; square perimeter: {sq.Perimeter()}");
    }
}